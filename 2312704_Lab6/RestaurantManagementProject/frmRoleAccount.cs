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
    public partial class frmRoleAccount : Form
    {
        private readonly RoleAccountBL bl = new RoleAccountBL();
        private readonly RoleBL roleBL = new RoleBL();
        private readonly AccountBL accountBL = new AccountBL(); // Giả sử bạn đã có AccountBL
        private string currentRoleID = "";
        private string currentAccountName = "";

        public frmRoleAccount()
        {
            InitializeComponent();
        }

        private void LoadComboBoxes()
        {
            // Load RoleID
            var roles = roleBL.GetAll();
            cbbRoleID.DisplayMember = "RoleName";
            cbbRoleID.ValueMember = "ID";
            cbbRoleID.DataSource = roles;

            // Load AccountName
            var accounts = accountBL.GetAll(); // Cần có AccountBL.GetAll()
            cbbAccountName.DisplayMember = "AccountName";
            cbbAccountName.ValueMember = "AccountName";
            cbbAccountName.DataSource = accounts;
        }

        private void LoadData()
        {
            var list = bl.GetAll();
            lsvRoleAccount.Items.Clear();
            int stt = 1;

            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(item.RoleID.ToString());
                lvi.SubItems.Add(item.AccountName ?? "");
                lvi.SubItems.Add(item.Actived ? "Kích hoạt" : "Chưa kích hoạt");
                lvi.SubItems.Add(item.Notes ?? "");
                lvi.Tag = item;
                lsvRoleAccount.Items.Add(lvi);
                stt++;
            }

            lblStatistic.Text = $"Tổng: {list.Count} phân quyền";
            ClearInput();
        }

        private void ClearInput()
        {
            cbbRoleID.SelectedIndex = -1;
            cbbAccountName.SelectedIndex = -1;
            chkActived.Checked = false;
            txtNotes.Clear();
            currentRoleID = "";
            currentAccountName = "";
        }

        private void frmRoleAccount_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
        }

        private void lsvRoleAccount_Click(object sender, EventArgs e)
        {
            if (lsvRoleAccount.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvRoleAccount.SelectedItems[0];
                RoleAccount ra = (RoleAccount)lvi.Tag;

                currentRoleID = ra.RoleID.ToString();
                currentAccountName = ra.AccountName;

                cbbRoleID.SelectedValue = ra.RoleID;
                cbbAccountName.SelectedValue = ra.AccountName;
                chkActived.Checked = ra.Actived;
                txtNotes.Text = ra.Notes ?? "";
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (cbbRoleID.SelectedValue == null || cbbAccountName.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Role và Tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RoleAccount ra = new RoleAccount
                {
                    RoleID = (int)cbbRoleID.SelectedValue,
                    AccountName = cbbAccountName.SelectedValue.ToString(),
                    Actived = chkActived.Checked,
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
                };

                int result = bl.Insert(ra);
                if (result > 0)
                {
                    MessageBox.Show("Phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Phân quyền thất bại! Có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (cbbRoleID.SelectedValue == null || cbbAccountName.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Role và Tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RoleAccount ra = new RoleAccount
                {
                    RoleID = (int)cbbRoleID.SelectedValue,
                    AccountName = cbbAccountName.SelectedValue.ToString(),
                    Actived = chkActived.Checked,
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
                };

                int result = bl.Insert(ra);
                if (result > 0)
                {
                    MessageBox.Show("Phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Phân quyền thất bại! Có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentRoleID) || string.IsNullOrEmpty(currentAccountName))
            {
                MessageBox.Show("Vui lòng chọn phân quyền để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RoleAccount ra = new RoleAccount
                {
                    RoleID = (int)cbbRoleID.SelectedValue,
                    AccountName = cbbAccountName.SelectedValue.ToString(),
                    Actived = chkActived.Checked,
                    Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim()
                };

                int result = bl.Update(ra);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ClearInput();
        }
    }
}
