using Lab07_Entity_Framework.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class BillDetailsForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();
        private readonly int _billId;

        public BillDetailsForm(int billId)
        {
            InitializeComponent();
            _billId = billId;

            colQuantity.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPrice.DefaultCellStyle.Format = "N0";
            colTotal.DefaultCellStyle.Format = "N0";

            LoadBillInfo();
            LoadBillDetails();
        }

        private void LoadBillInfo()
        {
            var bill = _db.Bills
                .Where(b => b.Id == _billId)
                .Select(b => new
                {
                    b.Name,
                    TableName = b.Table.Name,
                    b.CheckoutDate,
                    b.Account,
                    b.Amount,
                    Discount = b.Discount ?? 0,
                    Tax = b.Tax ?? 0
                })
                .FirstOrDefault();

            if (bill == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            Text = $"Chi tiết hóa đơn: {bill.Name}";
            lblBillInfo.Text = $"Bàn: {bill.TableName} | " +
                              $"Ngày: {bill.CheckoutDate:dd/MM/yyyy HH:mm} | " +
                              $"Nhân viên: {bill.Account}";

            lblAmount.Text = $"Tổng tiền: {bill.Amount:N0} ₫";
            lblDiscount.Text = $"Giảm giá: {(bill.Discount * 100):N0}%";
            lblTax.Text = $"Thuế: {(bill.Tax * 100):N0}%";

            var total = bill.Amount * (1 - bill.Discount) * (1 + bill.Tax);
            lblTotal.Text = $"Thực thu: {total:N0} ₫";
        }

        private void LoadBillDetails()
        {
            var details = _db.BillDetails
                .Where(bd => bd.InvoiceId == _billId)
                .Select(bd => new
                {
                    FoodName = bd.Food.FoodName,
                    bd.Quantity,
                    Price = bd.Food.Price,
                    Total = bd.Quantity * bd.Food.Price
                })
                .OrderBy(bd => bd.FoodName)
                .ToList();

            dgvDetails.DataSource = details;

            var totalFromDetails = details.Sum(d => d.Total);
            lblTotalFromDetails.Text = $"Tổng từ chi tiết: {totalFromDetails:N0} ₫";
        }
    }
}