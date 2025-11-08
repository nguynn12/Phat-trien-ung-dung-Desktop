using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace RestaurantManagementProject
{
    public partial class frmCategory : Form
    {
        private readonly CategoryBL bl = new CategoryBL();
        private int currentID = 0;

        public frmCategory()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var list = bl.GetAll();
            lsvCategory.Items.Clear();
            int stt = 1;

            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(item.ID.ToString());
                lvi.SubItems.Add(item.Name ?? "");
                lvi.SubItems.Add(item.Type == 0 ? "Thức ăn" : "Đồ uống"); // Giả sử 0 = thức ăn, 1 = đồ uống
                lvi.Tag = item;
                lsvCategory.Items.Add(lvi);
                stt++;
            }

            lblStatistic.Text = $"Tổng: {list.Count} nhóm món";
            ClearInput();
        }

        private void ClearInput()
        {
            txtID.Clear();
            txtName.Clear();
            cbbType.SelectedIndex = -1;
            currentID = 0;
        }

        private void lsvCategory_Click(object sender, EventArgs e)
        {
            if (lsvCategory.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvCategory.SelectedItems[0];
                Category cat = (Category)lvi.Tag;

                currentID = cat.ID;
                txtID.Text = cat.ID.ToString();
                txtName.Text = cat.Name ?? "";
                cbbType.SelectedIndex = cat.Type; // 0 hoặc 1
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhóm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (cbbType.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại nhóm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Category cat = new Category
                {
                    Name = txtName.Text.Trim(),
                    Type = cbbType.SelectedIndex // 0 = thức ăn, 1 = đồ uống
                };

                int result = bl.Insert(cat);
                if (result > 0)
                {
                    MessageBox.Show("Thêm nhóm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhóm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (cbbType.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại nhóm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Category cat = new Category
                {
                    Name = txtName.Text.Trim(),
                    Type = cbbType.SelectedIndex // 0 = thức ăn, 1 = đồ uống
                };

                int result = bl.Insert(cat);
                if (result > 0)
                {
                    MessageBox.Show("Thêm nhóm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (currentID == 0)
            {
                MessageBox.Show("Vui lòng chọn nhóm món để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên nhóm món không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (cbbType.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại nhóm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Category cat = new Category
                {
                    ID = currentID,
                    Name = txtName.Text.Trim(),
                    Type = cbbType.SelectedIndex
                };

                int result = bl.Update(cat);
                if (result > 0)
                {
                    MessageBox.Show("Sửa nhóm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
