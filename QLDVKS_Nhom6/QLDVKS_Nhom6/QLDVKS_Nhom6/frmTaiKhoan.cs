using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLDVKS_Nhom6
{
    public partial class frmTaiKhoan : Form
    {
        // Khai báo BL
        AccountBL accountBL = new AccountBL();
        RoleBL roleBL = new RoleBL();

        // Danh sách
        List<Account> listAccount = new List<Account>();
        List<Role> listRole = new List<Role>();

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadRoles();
            LoadAccounts();
        }

        private void SetupDataGridView()
        {
            dgvTaiKhoan.AutoGenerateColumns = false;
            // Ánh xạ cột (Tên "col..." phải khớp với .Designer.cs)
            colUsername.DataPropertyName = "Username";
            colDisplayName.DataPropertyName = "DisplayName";
            colRoleName.DataPropertyName = "RoleName";
        }

        private void LoadRoles()
        {
            listRole = roleBL.GetAll();
            cboRole.DataSource = listRole;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleID";
        }

        private void LoadAccounts()
        {
            listAccount = accountBL.GetAll();
            dgvTaiKhoan.DataSource = listAccount;
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtUsername.Text = "";
            txtDisplayName.Text = "";
            cboRole.SelectedIndex = -1;
            txtUsername.Enabled = true; // Cho phép nhập khi xóa trắng
            dgvTaiKhoan.ClearSelection();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string username = dgvTaiKhoan.Rows[e.RowIndex].Cells["colUsername"].Value.ToString();
            Account acc = listAccount.Find(a => a.Username == username);

            if (acc != null)
            {
                txtUsername.Text = acc.Username;
                txtDisplayName.Text = acc.DisplayName;
                cboRole.SelectedValue = acc.RoleID;
                txtUsername.Enabled = false; // Không cho sửa Khóa chính
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || cboRole.SelectedIndex == -1)
            {
                MessageBox.Show("Tên đăng nhập và Quyền là bắt buộc!");
                return;
            }

            // Kiểm tra trùng username
            if (listAccount.Exists(a => a.Username.Equals(txtUsername.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại!");
                return;
            }

            Account acc = new Account();
            acc.Username = txtUsername.Text.Trim();
            acc.DisplayName = txtDisplayName.Text.Trim();
            acc.RoleID = (int)cboRole.SelectedValue;

            if (accountBL.Insert(acc) > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công! Mật khẩu mặc định là '123'.");
                LoadAccounts();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Enabled == true)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản từ danh sách để sửa.");
                return;
            }

            Account acc = new Account();
            acc.Username = txtUsername.Text; // Khóa chính
            acc.DisplayName = txtDisplayName.Text.Trim();
            acc.RoleID = (int)cboRole.SelectedValue;

            if (accountBL.Update(acc) > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadAccounts();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Enabled == true)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản từ danh sách để xóa.");
                return;
            }

            if (txtUsername.Text.ToLower() == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản Admin gốc!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Account acc = new Account() { Username = txtUsername.Text };

            if (accountBL.Delete(acc) > 0)
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadAccounts();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Enabled == true)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản từ danh sách.");
                return;
            }

            string newPassword = "123"; // Đặt lại mật khẩu về '123'
            string username = txtUsername.Text;

            if (MessageBox.Show($"Bạn có muốn đặt lại mật khẩu cho '{username}' về '{newPassword}' không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if (accountBL.ResetPassword(username, newPassword) > 0)
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }
    }
}