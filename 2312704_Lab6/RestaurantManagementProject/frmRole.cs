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
    public partial class frmRole : Form
    {
        private readonly RoleBL bl = new RoleBL();
        private int currentID = 0;

        public frmRole()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var list = bl.GetAll();
            lsvRole.Items.Clear();
            int stt = 1;

            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(item.ID.ToString());
                lvi.SubItems.Add(item.RoleName ?? "");
                lvi.SubItems.Add(item.Path ?? "");
                lvi.SubItems.Add(item.Notes ?? "");
                lvi.Tag = item;
                lsvRole.Items.Add(lvi);
                stt++;
            }

            lblStatistic.Text = $"Tổng: {list.Count} quyền";
            ClearInput();
        }

        private void ClearInput()
        {
            txtID.Clear();
            txtRoleName.Clear();
            txtPath.Clear();
            txtNotes.Clear();
            currentID = 0;
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lsvRole_Click(object sender, EventArgs e)
        {
            if (lsvRole.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvRole.SelectedItems[0];
                Role r = (Role)lvi.Tag;

                currentID = r.ID;
                txtID.Text = r.ID.ToString();
                txtRoleName.Text = r.RoleName ?? "";
                txtPath.Text = r.Path ?? "";
                txtNotes.Text = r.Notes ?? "";
            }
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoleName.Focus();
                return;
            }

            try
            {
                Role r = new Role
                {
                    RoleName = txtRoleName.Text.Trim(),
                    Path = string.IsNullOrWhiteSpace(txtPath.Text) ? null : txtPath.Text.Trim(),
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
                };

                int result = bl.Insert(r);
                if (result > 0)
                {
                    MessageBox.Show("Thêm quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (currentID == 0)
            {
                MessageBox.Show("Vui lòng chọn quyền để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
            {
                MessageBox.Show("Tên quyền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoleName.Focus();
                return;
            }

            try
            {
                Role r = new Role
                {
                    ID = currentID,
                    RoleName = txtRoleName.Text.Trim(),
                    Path = string.IsNullOrWhiteSpace(txtPath.Text) ? null : txtPath.Text.Trim(),
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
                };

                int result = bl.Update(r);
                if (result > 0)
                {
                    MessageBox.Show("Sửa quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Vui lòng chọn quyền để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
            {
                MessageBox.Show("Tên quyền không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoleName.Focus();
                return;
            }

            try
            {
                Role r = new Role
                {
                    ID = currentID,
                    RoleName = txtRoleName.Text.Trim(),
                    Path = string.IsNullOrWhiteSpace(txtPath.Text) ? null : txtPath.Text.Trim(),
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
                };

                int result = bl.Update(r);
                if (result > 0)
                {
                    MessageBox.Show("Sửa quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
