using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312704_Bai2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            int n = int.Parse(txtSoN.Text);
            string kq = "";

            if (rdNoiHoTen.Checked)

                TinhToan.NoiChuoi(ho, ten, ref kq);

            else

                kq = Convert.ToString(TinhToan.GiaiThua(n));

            lblKetQua.Text = kq;
        }
    }
}
