using Lab07_Entity_Framework.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class FoodForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();

        public FoodForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadFoods();
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

            categories.Insert(0, new { Id = 0, DisplayName = "Tất cả nhóm món" });

            cbbCategory.DisplayMember = "DisplayName";
            cbbCategory.ValueMember = "Id";
            cbbCategory.DataSource = categories;
            cbbCategory.SelectedIndex = 0;
        }

        private void LoadFoods()
        {
            var categoryId = (int)cbbCategory.SelectedValue;

            var query = _db.Foods
                .Include(f => f.Category)
                .AsQueryable();

            if (categoryId > 0)
                query = query.Where(f => f.FoodCategoryId == categoryId);

            var foods = query
                .OrderBy(f => f.FoodName)
                .Select(f => new FoodModel
                {
                    Id = f.Id,
                    FoodName = f.FoodName,
                    Unit = f.Unit,
                    CategoryName = f.Category.Name + " (" + (f.Category.Type == CategoryType.Food ? "Đồ ăn" : "Nước uống") + ")",
                    Price = f.Price,
                    Notes = f.Notes
                })
                .ToList();

            dgvFoods.DataSource = foods;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFoods();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new FoodEditForm())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _db.Foods.Add(dlg.Food);
                    _db.SaveChanges();
                    LoadFoods();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count == 0) return;

            var foodId = (int)dgvFoods.SelectedRows[0].Cells[0].Value;
            var food = _db.Foods.Find(foodId);

            if (food == null) return;

            using (var dlg = new FoodEditForm(food))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    food.FoodName = dlg.Food.FoodName;
                    food.Unit = dlg.Food.Unit;
                    food.FoodCategoryId = dlg.Food.FoodCategoryId;
                    food.Price = dlg.Food.Price;
                    food.Notes = dlg.Food.Notes;

                    _db.SaveChanges();
                    LoadFoods();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count == 0) return;

            var foodId = (int)dgvFoods.SelectedRows[0].Cells[0].Value;
            var food = _db.Foods.Find(foodId);

            if (food == null) return;

            if (MessageBox.Show($"Xóa món '{food.FoodName}'?\n" +
                               "Dữ liệu sẽ bị xóa vĩnh viễn.", "Xác nhận",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _db.Foods.Remove(food);
                _db.SaveChanges();
                LoadFoods();
            }
        }
    }
}