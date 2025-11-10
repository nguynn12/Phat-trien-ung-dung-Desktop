using Lab07_Entity_Framework.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class ChangePasswordForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();
        private readonly string _accountName;

        public string NewPassword { get; private set; }

        public ChangePasswordForm(string accountName)
        {
            InitializeComponent();
            _accountName = accountName;
            LoadAccountInfo();
        }

        private void LoadAccountInfo()
        {
            var account = _db.Accounts.Find(_accountName);
            if (account != null)
            {
                lblAccountInfo.Text = $"Đổi mật khẩu cho: {account.FullName} ({account.AccountName})";
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Mật khẩu mới không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        }

        private void UpdatePasswordStrength()
        {
            var pwd = txtNewPassword.Text;
            int strength = 0;
            string message = "";

            if (pwd.Length >= 6) strength++;
            if (pwd.Any(char.IsUpper)) strength++;
            if (pwd.Any(char.IsLower)) strength++;
            if (pwd.Any(char.IsDigit)) strength++;
            if (pwd.Any(ch => "!@#$%^&*()".Contains(ch))) strength++;

            switch (strength)
            {
                case 0:
                case 1:
                    message = "Yếu"; lblStrength.ForeColor = System.Drawing.Color.Red; break;
                case 2:
                case 3:
                    message = "Trung bình"; lblStrength.ForeColor = System.Drawing.Color.Orange; break;
                case 4:
                case 5:
                    message = "Mạnh"; lblStrength.ForeColor = System.Drawing.Color.Green; break;
            }

            lblStrength.Text = $"Độ mạnh: {message}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            NewPassword = txtNewPassword.Text; // Có thể mã hóa sau
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordStrength();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}