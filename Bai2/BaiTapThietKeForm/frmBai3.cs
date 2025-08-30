using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();

        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghia.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);
            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghia.Text = "";
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            txtHienThi.Text = nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;
            txtHienThi.Text = list[stt];
        }
    }
}
