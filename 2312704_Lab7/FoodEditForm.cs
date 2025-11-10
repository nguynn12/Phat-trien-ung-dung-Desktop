using Lab07_Entity_Framework.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class FoodEditForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();
        public Food Food { get; private set; }

        public FoodEditForm(Food food = null)
        {
            InitializeComponent();
            Food = food ?? new Food();
            LoadCategories();
            LoadFoodData();
        }

        private void LoadCategories()
        {
            var categories = _db.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    c.Id,
                    DisplayName = c.Name + " (" + (c.Type == CategoryType.Food ? "Đồ ăn" : "Nước uống") + ")"
                })
                .ToList();

            cbbCategory.DisplayMember = "DisplayName";
            cbbCategory.ValueMember = "Id";
            cbbCategory.DataSource = categories;
        }

        private void LoadFoodData()
        {
            txtFoodName.Text = Food.FoodName;
            txtUnit.Text = Food.Unit;
            txtPrice.Text = Food.Price.ToString();
            txtNotes.Text = Food.Notes;

            if (Food.FoodCategoryId > 0)
            {
                cbbCategory.SelectedValue = Food.FoodCategoryId;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFoodName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn vị!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnit.Focus();
                return false;
            }

            if (!int.TryParse(txtPrice.Text, out int price) || price < 0)
            {
                MessageBox.Show("Giá phải là số nguyên dương!", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (cbbCategory.SelectedValue == null || (int)cbbCategory.SelectedValue == 0)
            {
                MessageBox.Show("Vui lòng chọn nhóm món!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbCategory.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Food.FoodName = txtFoodName.Text.Trim();
            Food.Unit = txtUnit.Text.Trim();
            Food.Price = int.Parse(txtPrice.Text);
            Food.Notes = txtNotes.Text.Trim();
            Food.FoodCategoryId = (int)cbbCategory.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép số
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}