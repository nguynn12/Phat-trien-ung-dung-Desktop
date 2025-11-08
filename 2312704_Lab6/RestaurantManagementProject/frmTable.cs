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
    public partial class frmTable : Form
    {
        private readonly RestaurantTableBL bl = new RestaurantTableBL();
        private int currentID = 0;

        public frmTable()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var list = bl.GetAll();
            lsvTable.Items.Clear();
            int stt = 1;

            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(item.ID.ToString());
                lvi.SubItems.Add(item.Name ?? "");
                lvi.SubItems.Add(GetStatusText(item.Status));
                lvi.SubItems.Add(item.Capacity.HasValue ? item.Capacity.Value.ToString() : "");
                lvi.Tag = item;
                lsvTable.Items.Add(lvi);
                stt++;
            }

            lblStatistic.Text = $"Tổng: {list.Count} bàn ăn";
            ClearInput();
        }

        private string GetStatusText(int status)
        {
            switch (status)
            {
                case 0: return "Trống";
                case 1: return "Đang dùng";
                case 2: return "Đã đặt trước";
                case 3: return "Bảo trì";
                default: return "Không xác định";
            }
        }

        private int GetStatusValue(string text)
        {
            switch (text)
            {
                case "Trống": return 0;
                case "Đang dùng": return 1;
                case "Đã đặt trước": return 2;
                case "Bảo trì": return 3;
                default: return 0;
            }
        }

        private void ClearInput()
        {
            txtID.Clear();
            txtName.Clear();
            cbbStatus.SelectedIndex = -1;
            txtCapacity.Clear();
            currentID = 0;
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lsvTable_Click(object sender, EventArgs e)
        {
            if (lsvTable.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvTable.SelectedItems[0];
                RestaurantTable t = (RestaurantTable)lvi.Tag;

                currentID = t.ID;
                txtID.Text = t.ID.ToString();
                txtName.Text = t.Name ?? "";
                cbbStatus.Text = GetStatusText(t.Status);
                txtCapacity.Text = t.Capacity.HasValue ? t.Capacity.Value.ToString() : "";
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (cbbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RestaurantTable t = new RestaurantTable
                {
                    Name = txtName.Text.Trim(),
                    Status = GetStatusValue(cbbStatus.Text),
                    Capacity = string.IsNullOrWhiteSpace(txtCapacity.Text) ? (int?)null : int.Parse(txtCapacity.Text)
                };

                int result = bl.Insert(t);
                if (result > 0)
                {
                    MessageBox.Show("Thêm bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (currentID == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên bàn không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (cbbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RestaurantTable t = new RestaurantTable
                {
                    ID = currentID,
                    Name = txtName.Text.Trim(),
                    Status = GetStatusValue(cbbStatus.Text),
                    Capacity = string.IsNullOrWhiteSpace(txtCapacity.Text) ? (int?)null : int.Parse(txtCapacity.Text)
                };

                int result = bl.Update(t);
                if (result > 0)
                {
                    MessageBox.Show("Sửa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (currentID == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Xóa bàn này có thể ảnh hưởng đến hóa đơn. Bạn có chắc muốn xóa?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    RestaurantTable t = new RestaurantTable { ID = currentID };
                    int result = bl.Delete(t);
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại! Bàn đang được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
