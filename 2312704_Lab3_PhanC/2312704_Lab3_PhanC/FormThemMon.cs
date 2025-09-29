using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312704_Lab3_PhanC
{
    public partial class FormThemMon : Form
    {
        public string TenMonHoc { get; private set; }

        public FormThemMon()
        {
            InitializeComponent();
        }

        private void FormThemMon_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }

            TenMonHoc = txtTenMonHoc.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
