using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab07_Entity_Framework.Models;

namespace Lab07_Entity_Framework
{
    public partial class MainForm : Form
    {
        private List<Category> GetCategories()
        {
            var dbContext = new RestaurantContext();

            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }

        private void ShowCategories()
        {
            tvwCategory.Nodes.Clear();

            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };

            var rootNode = tvwCategory.Nodes.Add("Tất cả");

            var categories = GetCategories();

            foreach (var cateType in cateMap)
            {
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;

                foreach (var category in categories)
                {
                    if (category.Type != cateType.Key) continue;

                    var grandChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grandChildNode.Tag = category;
                }
            }

            tvwCategory.ExpandAll();
            tvwCategory.SelectedNode = rootNode;
        }

        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            var dbContext = new RestaurantContext();

            var foods = dbContext.Foods.AsQueryable();

            if (categoryId != null && categoryId > 0)
            {
                foods = foods.Where(x => x.FoodCategoryId == categoryId);
            }

            return foods
                .Include(x => x.Category)
                .OrderBy(x => x.FoodName)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    FoodName = x.FoodName,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }

        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurantContext();

            return dbContext.Foods
                .Include(x => x.Category)
                .Where(x => x.Category.Type == cateType)
                .OrderBy(x => x.FoodName)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    FoodName = x.FoodName,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                })
                .ToList();
        }

        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach (var foodItem in foods)
            {
                var item = lvwFood.Items.Add(foodItem.Id.ToString());

                item.SubItems.Add(foodItem.FoodName);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }

        private void ShowFoodsForNodes(TreeNode node)
        {
            lvwFood.Items.Clear();

            if (node == null) return;

            List<FoodModel> foods = null;

            if (node.Level == 1)
            {
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }

            else if (node.Level == 2)
            {
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }

            else if (node.Level == 0)
            {
                foods = GetFoodByCategory(null); // hoặc query tất cả
            }

            ShowFoodsOnListView(foods);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNodes(e.Node);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;

            var category = e.Node.Tag as Category;
            var dialog = new UpdateCategoryForm(category?.Id);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodsForNodes(tvwCategory.SelectedNode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;

            var dbContext = new RestaurantContext();
            var selectedFoodId = int.Parse(lvwFood.SelectedItems[0].Text);

            var selectedFood = dbContext.Foods.Find(selectedFoodId);

            if (selectedFood != null)
            {
                dbContext.Foods.Remove(selectedFood);
                dbContext.SaveChanges();

                lvwFood.Items.Remove(lvwFood.SelectedItems[0]);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var selectedNode = tvwCategory.SelectedNode;
            int? categoryId = null;

            if (selectedNode?.Level == 2 && selectedNode.Tag is Category cat)
                categoryId = cat.Id;
            
            var dialog = new UpdateFoodForm(categoryId: categoryId);
            
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNodes(tvwCategory.SelectedNode);
            }
        }

        private void lvwFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;

            var foodId = int.Parse(lvwFood.SelectedItems[0].Text);
            var dialog = new UpdateFoodForm(foodId);

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNodes(tvwCategory.SelectedNode);
            }
        }
    }
}
