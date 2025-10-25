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
    public partial class frmGiangVien : Form
    {
        QuanLyGiangVien qlgv = new QuanLyGiangVien();

        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lbHocPhanDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienHe.Length, lienHe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDSHocPhan.SelectedItems.Count - 1;

            while (i >= 0)
            {
                this.lbHocPhanDay.Items.Add(lbDSHocPhan.SelectedItems[i]);
                this.lbDSHocPhan.Items.Remove(lbDSHocPhan.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbHocPhanDay.SelectedItems.Count - 1;

            while (i >= 0)
            {
                this.lbDSHocPhan.Items.Add(lbHocPhanDay.SelectedItems[i]);
                this.lbHocPhanDay.Items.Remove(lbHocPhanDay.SelectedItems[i]);
                i--;
            }
        }

        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;

            for (int i = 0; i< chklbNgoaiNgu.Items.Count - 1; i++)

                chklbNgoaiNgu.SetItemChecked(i, false);

            foreach (object ob in this.lbHocPhanDay.Items)

                this.lbDSHocPhan.Items.Add(ob);

            this.lbHocPhanDay.Items.Clear();      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        public void DuaGVLenConTrol(GiangVien gv)
        {
            cboMaSo.Text = gv.MaSo;

            if (gv.GioiTinh == "")
                rdNam.Checked = true;
            rdNu


        }

        public GiangVien GetGiangVien()
        {
            string gt = "Nam";

            if (rdNu.Checked)

                gt = "Nu";
            
            GiangVien gv = new GiangVien();

            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;

            string ngoaiNgu = "";

            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)

                if (chklbNgoaiNgu.GetItemChecked(i))

                    ngoaiNgu += chklbNgoaiNgu.Items[i] + ";";

            gv.NgoaiNgu = ngoaiNgu.Split(';');

            DanhMucHocPhan dshp = new DanhMucHocPhan();

            foreach (object hp in lbHocPhanDay.Items)

                dshp.Them(new HocPhan(hp.ToString()));

            gv.dsHocPhan = dshp;

            return gv;
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmTBGiangVien frm = new frmTBGiangVien();
            frm.SetText(GetGiangVien().ToString());
            frm.ShowDialog();
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strlink = e.Link.LinkData.ToString();
            
        }

        private int SoSanhTheoMa(object sv1, object sv2)
        {
            GiangVien gv = sv2 as GiangVien;
            return gv.MaSo.CompareTo(sv1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kq = false;
            GiangVien gv = GetGiangVien();

            if (qlgv.Tim(gv.MaSo, SoSanhTheoMa) != null)

                MessageBox.Show("Mã giảng viên đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                kq = qlgv.Them(gv);
            }    
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var form = new frmTimGV();
            form.ShowDialog();
        }
    }
}
