using Lab07_Entity_Framework.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class BillsForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();
        private int? _tableIdFilter;

        public BillsForm()
        {
            InitializeComponent();
            SetupDataGridView();
            SetDefaultDateRange();

            // Nhận tableId từ Tag
            if (this.Tag is int tableId)
                _tableIdFilter = tableId;
        }

        private void SetupDataGridView()
        {
            dgvBills.AutoGenerateColumns = false;
            dgvBills.Columns.Clear();

            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 60
            });
            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Tên hóa đơn",
                Width = 120
            });
            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TableName",
                HeaderText = "Bàn",
                Width = 80
            });
            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Tổng tiền",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Discount",
                HeaderText = "Giảm giá",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "P0" }
            });
            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tax",
                HeaderText = "Thuế",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "P0" }
            });
            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Thực thu",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CheckoutDate",
                HeaderText = "Ngày thanh toán",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
            dgvBills.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Account",
                HeaderText = "Nhân viên",
                Width = 100
            });
        }

        private void SetDefaultDateRange()
        {
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;
        }

        private void LoadBills()
        {
            var fromDate = dtpFrom.Value.Date;
            var toDate = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

            var query = _db.Bills.AsQueryable();

            // LỌC THEO BÀN NẾU CÓ
            if (_tableIdFilter.HasValue)
                query = query.Where(b => b.TableId == _tableIdFilter.Value);

            query = query.Where(b => b.CheckoutDate >= fromDate && b.CheckoutDate <= toDate);

            var bills = query
                .OrderByDescending(b => b.CheckoutDate)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    TableName = b.Table.Name,
                    b.Amount,
                    Discount = b.Discount ?? 0,
                    Tax = b.Tax ?? 0,
                    TotalAmount = b.Amount * (1 - (b.Discount ?? 0)) * (1 + (b.Tax ?? 0)),
                    b.CheckoutDate,
                    b.Account
                })
                .ToList();

            dgvBills.DataSource = bills;

            // Tính tổng (giữ nguyên)
            var totalAmount = bills.Sum(b => b.Amount);
            var totalDiscount = bills.Sum(b => b.Amount * b.Discount);
            var totalTax = bills.Sum(b => b.Amount * (1 - b.Discount) * b.Tax);
            var totalReceived = bills.Sum(b => b.TotalAmount);

            lblSummary.Text = $"Tổng tiền: {totalAmount:N0} | " +
                             $"Giảm giá: {totalDiscount:N0} | " +
                             $"Thuế: {totalTax:N0} | " +
                             $"Thực thu: {totalReceived:N0}";
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            LoadBills();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBills();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
                dtpTo.Value = dtpFrom.Value;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTo.Value < dtpFrom.Value)
                dtpFrom.Value = dtpTo.Value;
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var billId = (int)dgvBills.Rows[e.RowIndex].Cells[0].Value;
            using (var dlg = new BillDetailsForm(billId))
            {
                dlg.ShowDialog(this);
            }
        }
    }
}