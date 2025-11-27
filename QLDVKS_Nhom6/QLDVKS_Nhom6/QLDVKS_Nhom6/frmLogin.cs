using BusinessLogic;
using DataAccess;
using System;
using System.Windows.Forms;

namespace QLDVKS_Nhom6
{
    public partial class frmLogin : Form
    {
        // Khai báo lớp Business Logic
        AccountBL accountBL = new AccountBL();

        public Account LoggedInAccount { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 1. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gọi tầng Business Logic
            // (Tầng BL sẽ gọi DA, DA sẽ gọi SP Account_Login)
            // SP Account_Login sẽ tự động hash mật khẩu và so sánh
            Account account = accountBL.Login(username, password);

            // 3. Xử lý kết quả
            if (account != null)
            {
                // Đăng nhập thành công
                this.LoggedInAccount = account; // Lưu lại thông tin tài khoản
                this.DialogResult = DialogResult.OK; // Đặt kết quả là OK
                this.Close(); // Đóng form login
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // HÀM MỚI: Xử lý nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // HÀM MỚI: Xử lý nhấn Enter
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi sự kiện click của nút Đăng nhập
                btnLogin_Click(sender, e);
            }
        }
    }
}