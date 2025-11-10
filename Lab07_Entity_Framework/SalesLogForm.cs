using Lab07_Entity_Framework.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class SalesLogForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();
        private readonly int _tableId;
        private readonly string _tableName;

        public SalesLogForm(int tableId, string tableName)
        {
            InitializeComponent();
            _tableId = tableId;
            _tableName = tableName;

            this.Text = $"Nhật ký bán hàng - Bàn: {_tableName}";

            LoadSalesLog();
        }

        private void LoadSalesLog()
        {
            var bills = _db.Bills
                .Where(b => b.TableId == _tableId && b.CheckoutDate.HasValue)
                .OrderByDescending(b => b.CheckoutDate)
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

            dgvLog.DataSource = bills;

            // === TÍNH TỔNG HỢP ===
            int totalBills = bills.Count;
            int totalAmount = bills.Sum(b => b.Amount);
            double totalDiscount = bills.Sum(b => b.Amount * b.Discount);
            double totalTax = bills.Sum(b => b.Amount * (1 - b.Discount) * b.Tax);
            double totalReceived = bills.Sum(b => b.Total);

            lblSummary.Text =
                $"Tổng: {totalBills} hóa đơn | " +
                $"Tiền hàng: {totalAmount:N0} | " +
                $"Giảm giá: {totalDiscount:N0} | " +
                $"Thuế: {totalTax:N0} | " +
                $"Thực thu: {totalReceived:N0}";
        }
    }
}