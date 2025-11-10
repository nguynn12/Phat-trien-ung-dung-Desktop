using System;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }






        private void ShowForm<T>(string title) where T : Form, new()
        {
            var formName = typeof(T).Name;
            var form = Application.OpenForms[formName];

            if (form == null)
            {
                form = new T();
                form.Text = title;
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void mnuFood_Click(object sender, EventArgs e)
        {
            ShowForm<FoodForm>("Quản lý món ăn");
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            ShowForm<MainForm>("Quản lý nhóm món"); // ← MainForm là CategoryForm
        }

        private void mnuTable_Click(object sender, EventArgs e)
        {
            ShowForm<TableForm>("Quản lý bàn ăn");
        }

        private void mnuBill_Click(object sender, EventArgs e)
        {
            ShowForm<BillsForm>("Quản lý hóa đơn");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}