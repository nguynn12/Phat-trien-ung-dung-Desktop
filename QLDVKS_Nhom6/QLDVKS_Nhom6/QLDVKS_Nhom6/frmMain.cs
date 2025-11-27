using DataAccess;
using System;
using System.Windows.Forms;

namespace QLDVKS_Nhom6
{
    public partial class frmMain : Form
    {
        private Account loggedInAccount;

        public frmMain(Account account)
        {
            InitializeComponent();
            this.loggedInAccount = account;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            lblUserInfo.Text = $"Xin chào, {loggedInAccount.DisplayName} ({loggedInAccount.RoleName})";

            bool isAdmin = (loggedInAccount.RoleName == "Quản lý");
            btnTaiKhoan.Visible = isAdmin;
            btnDoanhThu.Visible = isAdmin;

            OpenForm<frmChinh>("Quản lý Dịch vụ");
        }

        private void OpenForm<T>(string title) where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(T))
                {
                    f.Activate();
                    return;
                }
            }

            T form = new T
            {
                Text = title,
                MdiParent = this,
                Dock = DockStyle.Fill,
                WindowState = FormWindowState.Maximized,
                ControlBox = false
            };
            form.Show();
        }

        private void btnPhongKH_Click(object sender, EventArgs e)
        {
            OpenForm<frmPhongKH>("Quản lý Phòng & Khách hàng");
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OpenForm<frmChinh>("Quản lý Dịch vụ");
        }

        // XÓA: Hàm btnThanhToan_Click đã bị xóa

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenForm<frmDoanhThu>("Thống kê doanh thu");
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            // SỬA: Mở frmTaiKhoan như một MDI child
            OpenForm<frmTaiKhoan>("Quản lý Tài khoản");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?",
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}