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
    public partial class FormTimKiem : Form
    {

        public string GiaTriTim { get; set; }

        public KieuSoSanh Kieu { get; set; }

        public FormTimKiem()
        {
            InitializeComponent();

            rdTheoMSSV.CheckedChanged += Radio_CheckedChanged;
            rdTheoTen.CheckedChanged += Radio_CheckedChanged;
            rdTheoLop.CheckedChanged += Radio_CheckedChanged;
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTheoMSSV.Checked)
                lblTimSV.Text = "MSSV:";

            else if (rdTheoTen.Checked)
                lblTimSV.Text = "Tên:";

            else if (rdTheoTen.Checked)
                lblTimSV.Text = "Lớp:";
        }



        private void FormTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            string giaTriTim = txtTimSV.Text.Trim();

            if (rdTheoMSSV.Checked)
            {
                if (giaTriTim.Length != 7 || !giaTriTim.All(char.IsDigit))
                {
                    MessageBox.Show("MSSV phải gồm 7 chữ số!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Kieu = KieuSoSanh.TheoMSSV;
            }

            else if (rdTheoTen.Checked)
            {
                if (string.IsNullOrEmpty(giaTriTim))
                {
                    MessageBox.Show("Vui lòng nhập tên sinh viên!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Kieu = KieuSoSanh.TheoTen;
            }

            else if (rdTheoLop.Checked)
            {
                if (string.IsNullOrEmpty(giaTriTim))
                {
                    MessageBox.Show("Vui lòng nhập lớp!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Kieu = KieuSoSanh.TheoLop;
            }

            else
            {
                MessageBox.Show("Bạn chưa chọn điều kiện tìm kiếm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu giá trị hợp lệ thì lưu kết quả
            GiaTriTim = giaTriTim;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
