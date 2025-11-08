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
    public partial class frmLogin : Form
    {
        private readonly AccountBL accountBL = new AccountBL();
        private readonly RoleAccountBL roleAccountBL = new RoleAccountBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var account = accountBL.GetAll()
                .FirstOrDefault(a => a.AccountName == username && a.Password == password);

            if (account == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy quyền từ DB
            var roles = roleAccountBL.GetAll()
                .Where(r => r.AccountName == username && r.Actived)
                .ToList();

            if (!roles.Any())
            {
                MessageBox.Show("Tài khoản không có quyền truy cập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // GÁN VÀO GLOBAL (DataAccess)
            Global.CurrentUser = account;
            Global.UserRoles = roles;

            MessageBox.Show($"Đăng nhập thành công!\nChào {account.FullName}",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mở form chính
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
