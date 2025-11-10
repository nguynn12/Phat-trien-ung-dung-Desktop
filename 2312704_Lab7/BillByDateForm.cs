using Lab07_Entity_Framework.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class BillByDateForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();
        private readonly int _tableId;
        private readonly string _tableName;

        public BillByDateForm(int tableId, string tableName)
        {
            InitializeComponent();
            _tableId = tableId;
            _tableName = tableName;

            this.Text = $"Hóa đơn theo ngày - Bàn: {_tableName}";

            // Gán event (bạn đã comment trong Designer)
            lstDates.SelectedIndexChanged += lstDates_SelectedIndexChanged;
            dgvBills.CellDoubleClick += dgvBills_CellDoubleClick;

            // Format cột (không thể set trong Designer)
            colCheckoutDate.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            colAmount.DefaultCellStyle.Format = "N0";
            colDiscount.DefaultCellStyle.Format = "P0";
            colTax.DefaultCellStyle.Format = "P0";
            colTotal.DefaultCellStyle.Format = "N0";

            LoadBillDates();
        }

        private void LoadBillDates()
        {
            var dates = _db.Bills
                .Where(b => b.TableId == _tableId && b.CheckoutDate.HasValue)
                .OrderByDescending(b => b.CheckoutDate.Value)
                .Select(b => b.CheckoutDate.Value.Date)
                .Distinct()
                .ToList();

            lstDates.DataSource = dates;
            lstDates.DisplayMember = "dd/MM/yyyy";
        }

        private void lstDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDates.SelectedItem is DateTime selectedDate)
            {
                var bills = _db.Bills
                    .Where(b => b.TableId == _tableId &&
                               b.CheckoutDate.HasValue &&
                               b.CheckoutDate.Value.Date == selectedDate.Date)
                    .OrderBy(b => b.CheckoutDate)
                    .Select(b => new
                    {
                        b.Id,
                        b.Name,
                        b.CheckoutDate,
                        b.Account,
                        b.Amount,
                        Discount = b.Discount ?? 0,
                        Tax = b.Tax ?? 0,
                        Total = b.Amount * (1 - (b.Discount ?? 0)) * (1 + (b.Tax ?? 0))
                    })
                    .ToList();

                dgvBills.DataSource = bills;
            }
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var billId = (int)dgvBills.Rows[e.RowIndex].Cells["colBillId"].Value;

            using (var detailForm = new BillDetailsForm(billId))
            {
                detailForm.ShowDialog(this);
            }
        }
    }
}