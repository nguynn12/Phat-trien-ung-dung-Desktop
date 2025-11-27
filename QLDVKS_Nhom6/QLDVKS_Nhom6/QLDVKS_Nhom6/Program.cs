using DataAccess;
using System;
using System.Windows.Forms;

namespace QLDVKS_Nhom6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Khởi tạo và hiển thị form Login
            frmLogin loginForm = new frmLogin();
            DialogResult result = loginForm.ShowDialog();

            // 2. Kiểm tra kết quả đăng nhập
            if (result == DialogResult.OK)
            {
                // Đăng nhập thành công
                // Lấy tài khoản đã đăng nhập từ frmLogin
                Account loggedInAccount = loginForm.LoggedInAccount;

                // 3. Mở frmMain và truyền tài khoản vào
                Application.Run(new frmMain(loggedInAccount));
            }
            // Nếu DialogResult là Cancel (bấm Thoát), ứng dụng sẽ tự động kết thúc
        }
    }
}