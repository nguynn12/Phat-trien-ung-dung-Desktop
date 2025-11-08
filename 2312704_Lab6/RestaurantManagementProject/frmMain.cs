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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            btnAccount.Visible = false;
            btnRole.Visible = false;
            btnRoleAccount.Visible = false;
            btnCategory.Visible = false;
            btnFood.Visible = false;
            btnTable.Visible = false;
            btnBills.Visible = false;
            btnBillDetails.Visible = false;
            btnOrder.Visible = false;
            btnPayment.Visible = false;

            // Ẩn nút nếu không có quyền
            btnAccount.Visible = Global.IsAdmin() || Global.IsManager();
            btnRole.Visible = Global.IsAdmin();
            btnRoleAccount.Visible = Global.IsAdmin();

            btnCategory.Visible = Global.IsAdmin() || Global.IsManager();
            btnFood.Visible = Global.IsAdmin() || Global.IsManager();
            btnTable.Visible = Global.IsAdmin() || Global.IsManager() || Global.IsStaff();

            btnBills.Visible = Global.IsAdmin() || Global.IsManager() || Global.IsAccountant();
            btnBillDetails.Visible = Global.IsAdmin() || Global.IsManager() || Global.IsAccountant();

            btnOrder.Visible = Global.IsStaff() || Global.IsManager();
            btnPayment.Visible = Global.IsAccountant() || Global.IsStaff();
        }

        private void OpenForm<T>(string title) where T : Form, new()
        {
            // Kiểm tra xem form đã mở chưa
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(T))
                {
                    f.Activate();
                    return;
                }
            }

            // Mở form mới
            T form = new T
            {
                Text = title,
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            form.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenForm<frmAccount>("Quản lý tài khoản");
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenForm<frmCategory>("Quản lý nhóm món ăn");
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenForm<frmFood>("Quản lý món ăn");
        }

        private void btnBillDetails_Click(object sender, EventArgs e)
        {
            OpenForm<frmBillDetails>("Quản lý chi tiết hóa đơn");
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OpenForm<frmBills>("Quản lý hóa đơn");
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            OpenForm<frmRole>("Quản lý quyền");
        }

        private void btnRoleAccount_Click(object sender, EventArgs e)
        {
            OpenForm<frmRoleAccount>("Phân quyền tài khoản");
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            OpenForm<frmTable>("Quản lý bàn ăn");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?",
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Global.Logout();
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenForm<frmOrder>("Đặt món");
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenForm<frmPayment>("Thanh toán");
        }
    }
}
