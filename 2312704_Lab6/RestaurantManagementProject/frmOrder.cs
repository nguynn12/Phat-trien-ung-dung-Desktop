using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
    public partial class frmOrder : Form
    {
        private readonly RestaurantTableBL tableBL = new RestaurantTableBL();
        private readonly CategoryBL categoryBL = new CategoryBL();
        private readonly FoodBL foodBL = new FoodBL();
        private readonly BillsBL billsBL = new BillsBL();
        private readonly BillDetailsBL billDetailsBL = new BillDetailsBL();

        private int currentTableID = 0;
        private int currentBillID = 0;
        private List<BillDetails> orderItems = new List<BillDetails>();

        public frmOrder()
        {
            InitializeComponent();
        }

        #region === TẢI DỮ LIỆU ===
        private void LoadTables()
        {
            var tables = tableBL.GetAll()
                .Where(t => t.Status == 0 || t.Status == 1) // Bàn trống hoặc đang dùng
                .ToList();

            cbbTable.DataSource = tables;
            cbbTable.DisplayMember = "Name";
            cbbTable.ValueMember = "ID";
        }

        private void LoadCategories()
        {
            var categories = categoryBL.GetAll();
            cbbCategory.DataSource = categories;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }

        private void LoadFoodsByCategory()
        {
            if (cbbCategory.SelectedValue == null) return;

            int catID = (int)cbbCategory.SelectedValue;
            var foods = foodBL.GetAll().Where(f => f.FoodCategoryID == catID).ToList();

            cbbFood.DataSource = foods;
            cbbFood.DisplayMember = "Name";
            cbbFood.ValueMember = "ID";
        }

        private void LoadOrderItems()
        {
            if (currentBillID == 0) return;

            orderItems = billDetailsBL.GetAll()
                .Where(d => d.InvoiceID == currentBillID)
                .ToList();

            lsvOrder.Items.Clear();
            decimal total = 0;

            foreach (var item in orderItems)
            {
                var food = foodBL.GetAll().FirstOrDefault(f => f.ID == item.FoodID);
                if (food == null) continue;

                ListViewItem lvi = new ListViewItem(food.Name);
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(food.Price.ToString("N0"));
                decimal amount = item.Quantity * food.Price;
                lvi.SubItems.Add(amount.ToString("N0"));
                lvi.Tag = item;
                lsvOrder.Items.Add(lvi);

                total += amount;
            }

            lblTotal.Text = $"Tổng tiền: {total:N0} VNĐ";
        }



        #endregion

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFoodsByCategory();
        }

        private void cbbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTable.SelectedValue == null) return;

            currentTableID = (int)cbbTable.SelectedValue;
            var table = tableBL.GetAll().FirstOrDefault(t => t.ID == currentTableID);

            // Kiểm tra trạng thái bàn
            if (table.Status == 1)
            {
                // Bàn đang dùng → tìm hóa đơn chưa thanh toán
                var bill = billsBL.GetAll().FirstOrDefault(b => b.TableID == currentTableID && !b.Status);
                if (bill != null)
                {
                    currentBillID = bill.ID;
                    LoadOrderItems();
                }
            }
            else
            {
                currentBillID = 0;
                orderItems.Clear();
                lsvOrder.Items.Clear();
                lblTotal.Text = "Tổng tiền: 0 VNĐ";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentTableID == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbFood.SelectedValue == null || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng chọn món và nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foodID = (int)cbbFood.SelectedValue;
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo hóa đơn nếu chưa có
            if (currentBillID == 0)
            {
                Bills newBill = new Bills
                {
                    Name = $"HĐ-{DateTime.Now:yyyyMMddHHmmss}",
                    TableID = currentTableID,
                    Amount = 0,
                    Discount = 0,
                    Tax = 0.1f,
                    Status = false,
                    Account = Global.CurrentUser.AccountName,
                    CheckoutDate = null
                };
                currentBillID = billsBL.Insert(newBill);

                // Cập nhật bàn = 1 (đang dùng)
                var table = new RestaurantTable { ID = currentTableID, Status = 1 };
                tableBL.Update(table);
            }

            // Thêm món vào chi tiết
            BillDetails detail = new BillDetails
            {
                InvoiceID = currentBillID,
                FoodID = foodID,
                Quantity = quantity
            };
            billDetailsBL.Insert(detail);

            // Refresh
            LoadOrderItems();
            txtQuantity.Clear();
            txtQuantity.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvOrder.SelectedItems.Count == 0) return;

            var item = (BillDetails)lsvOrder.SelectedItems[0].Tag;
            billDetailsBL.Delete(item);
            LoadOrderItems();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        private void ClearOrder()
        {
            txtQuantity.Clear();
            cbbFood.SelectedIndex = -1;
            orderItems.Clear();
            lsvOrder.Items.Clear();
            lblTotal.Text = "Tổng tiền: 0 VNĐ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
