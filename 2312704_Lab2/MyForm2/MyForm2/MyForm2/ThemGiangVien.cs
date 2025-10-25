using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm2
{
    public partial class frmTimGV : Form
    {
        QuanLyGiangVien qlgv = new QuanLyGiangVien();

        KieuTim kieu;

        public frmTimGV()
        {
            InitializeComponent();
        }

        public int SoSanhTheoLoai(object gv1, object gv2)
        {
            GiangVien gv = gv2 as GiangVien;

            if (kieu == KieuTim.TheoMa)

                return gv.MaSo.CompareTo(gv1);

            if (kieu == KieuTim.TheoHoTen)

                return gv.HoTen.CompareTo(gv1);

            return gv.SoDT.CompareTo(gv1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             string str = txtTim.Text.Trim();

            if (rdMaGV.Checked)
            {
                kieu = KieuTim.TheoMa;
                lblTim.Text = "Mã GV";
            }

            if (rdHoTen.Checked)
            {
                kieu = KieuTim.TheoHoTen;
                lblTim.Text = "Họ tên";
            }

            if (rdSDT.Checked)
            {
                kieu = KieuTim.TheoSDT;
                lblTim.Text = "SDT";
            }

            GiangVien gv = qlgv.Tim(str, SoSanhTheoLoai);

            if (gv != null)
            {
                // Tìm thấy
            }

            else
            {

            }
        }

        private void frmTimGV_Load(object sender, EventArgs e)
        {

        }
    }
}
