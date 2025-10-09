using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312704_TaNhatNguyen_De02
{
    public partial class frmQLNhapHang : Form
    {
        public frmQLNCC fQLNCC { get; set; }

        public frmQLNhapHang()
        {
            InitializeComponent();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            var form = new frmQLNCC();

            form.ShowDialog();

            //txtNhaCC.Text = form.LayTen();
        }
    }
}
