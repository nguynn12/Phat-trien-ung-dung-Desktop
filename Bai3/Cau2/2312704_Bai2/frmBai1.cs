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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }
        #region Ko quan trong
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            
        }
        #endregion 

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi("TB001", "Máy chiếu", "Mỹ", 15000000, 5);

            lblKetQua.Text = tb.HienThi();
        }
    }
}
