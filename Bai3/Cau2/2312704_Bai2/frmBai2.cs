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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSoThuNhat.Text);
            int so2 = int.Parse(txtSoThuHai.Text);
            int kq = 0;

            if (rdCong.Checked)

                kq = so1 + so2;

            else if (rdTru.Checked)

                kq = so1 - so2;

            else if (rdNhan.Checked)

                kq = so1 * so2;

            else

                kq = so1 / so2;

                lblKetQua.Text = kq.ToString();

        }
    }
}
