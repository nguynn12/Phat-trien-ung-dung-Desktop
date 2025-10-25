using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312704_Lab3_PhanC
{
    public partial class Form1 : Form
    {
        QLSinhVien qlsv = new QLSinhVien();

        KieuSoSanh kieu;

        public Form1()
        {
            InitializeComponent();
        }

        #region Ko quan trong
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion


        #region Cac ham bo tro
        private SinhVien LaySVTuControl()
        {
            SinhVien sv = new SinhVien();
            bool gioiTinh = true;
            List<string> monHoc = new List<string>();

            sv.MSSV = mtxtMSSV.Text;
            sv.HoTenLot = txtHoVaTen.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.CMND = mtxtCMND.Text;
            sv.DiaChi = txtDiaChi.Text;

            if (rdNu.Checked)
                gioiTinh = false;
            sv.GioiTinh = gioiTinh;

            sv.Ten = txtTen.Text;
            sv.Lop = cboLop.Text;
            sv.SDT = new string(mtxtSDT.Text.Where(char.IsDigit).ToArray());

            for (int i = 0; i < clbMonHoc.Items.Count; i++)

                if (clbMonHoc.GetItemChecked(i))

                    monHoc.Add(clbMonHoc.Items[i].ToString());

            sv.MonHoc = monHoc;

            return sv;
        }

        private SinhVien LaySVTuListView(ListViewItem lvitem)
        {
            if (lvitem.Tag is SinhVien svGoc)
            {
                SinhVien sv = new SinhVien
                {
                    MSSV = svGoc.MSSV,
                    HoTenLot = svGoc.HoTenLot,
                    Ten = svGoc.Ten,
                    NgaySinh = svGoc.NgaySinh,
                    CMND = svGoc.CMND,
                    DiaChi = svGoc.DiaChi,
                    GioiTinh = svGoc.GioiTinh,
                    Lop = svGoc.Lop,
                    SDT = svGoc.SDT,
                    MonHoc = new List<string>(svGoc.MonHoc)
                };

                return sv;
            }

            return null;
        }

        private void XuatSVTrenLV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.CMND);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.DiaChi);

            lvitem.Tag = sv;

            lvSinhVien.Items.Add(lvitem);
        }

        private void XuatSVTrenControl(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoVaTen.Text = sv.HoTenLot;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.mtxtCMND.Text = sv.CMND;
            this.txtDiaChi.Text = sv.DiaChi;
            this.txtTen.Text = sv.Ten;
            this.cboLop.Text = sv.Lop;
            this.mtxtSDT.Text = sv.SDT;

            if (sv.GioiTinh)
                rdNam.Checked = true;
            else
                rdNu.Checked = true;

            for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
                this.clbMonHoc.SetItemChecked(i, false);

            foreach (string mh in sv.MonHoc)
            {
                for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
                    if (mh.CompareTo(this.clbMonHoc.Items[i]) == 0)
                        this.clbMonHoc.SetItemChecked(i, true);
            }
        }

        private void LoadListView()
        {
            lvSinhVien.Items.Clear();

            foreach (SinhVien sv in qlsv.dsSinhVien)

                XuatSVTrenLV(sv);
        }

        private int SoSanhTheoLoai(object sv1, object sv2)
        {
            SinhVien sv = sv2 as SinhVien;

            if (kieu == KieuSoSanh.TheoTen)

                return sv.Ten.CompareTo(sv1);

            if (kieu == KieuSoSanh.TheoLop)

                return sv.Lop.CompareTo(sv1);

            return sv.MSSV.CompareTo(sv1);
        }

        private bool ValidateSinhVien()
        {
            // Kiểm tra bỏ trống
            if (string.IsNullOrWhiteSpace(mtxtMSSV.Text) ||
                    string.IsNullOrWhiteSpace(txtHoVaTen.Text) ||
                    string.IsNullOrWhiteSpace(mtxtCMND.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtTen.Text) ||
                    string.IsNullOrWhiteSpace(cboLop.Text) ||
                    string.IsNullOrWhiteSpace(mtxtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi thêm dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // MSSV phải 7 chữ số
            if (mtxtMSSV.Text.Length != 7 || !mtxtMSSV.Text.All(char.IsDigit))
            {
                MessageBox.Show("MSSV phải gồm 7 chữ số!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // CMND phải 9 chữ số
            if (mtxtCMND.Text.Length != 9 || !mtxtCMND.Text.All(char.IsDigit))
            {
                MessageBox.Show("CMND phải gồm 9 chữ số!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // SDT phải 10 chữ số
            // Lấy ra số điện thoại chỉ gồm chữ số (do maskedtexbox có dấu chấm)
            string rawSDT = new string(mtxtSDT.Text.Where(char.IsDigit).ToArray());
            if (rawSDT.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion


        #region Cac ham su kien
        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QLSinhVien();

            qlsv.DocTuFile("dssvtxt.txt");

            LoadListView();
        }

        // Đưa sv từ listview lên control
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;

            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = LaySVTuListView(lvitem);
                XuatSVTrenControl(sv);
            }
        }

        // Thêm sv
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!ValidateSinhVien())
                return;

            kieu = KieuSoSanh.TheoMSSV;

            SinhVien sv = LaySVTuControl();

            if (qlsv.Tim(sv.MSSV, SoSanhTheoLoai) != null)

                MessageBox.Show("MSSV đã tồn tại!", "Lỗi thêm dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                this.qlsv.Them(sv);
                this.qlsv.GhiFile("dssvtxt.txt");
                this.LoadListView();
            }
        }

        // Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (FormTimKiem f = new FormTimKiem())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string str = f.GiaTriTim;
                    kieu = f.Kieu;

                    List<SinhVien> dskq = qlsv.TimTatCa(str, SoSanhTheoLoai);

                    lvSinhVien.Items.Clear();

                    foreach (SinhVien sv in dskq)

                        XuatSVTrenLV(sv);

                    if (dskq.Count == 0)

                        MessageBox.Show("Không tìm thấy sinh viên nào!");
                }
            }
        }

        // Xóa, thêm môn học
        int indexClicked = -1;
        private void clbMonHoc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                indexClicked = clbMonHoc.IndexFromPoint(e.Location);
                clbMonHoc.SelectedIndex = indexClicked;
            }
        }

        // Xóa môn học
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexClicked >= 0 && indexClicked < clbMonHoc.Items.Count)
            {
                clbMonHoc.Items.RemoveAt(indexClicked);
                indexClicked = -1;
            }
        }

        // Thêm môn học
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormThemMon f = new FormThemMon())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    clbMonHoc.Items.Add(f.TenMonHoc, false);
            }
        }

        // Cập nhật sv
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateSinhVien())
                return;

            SinhVien sv = LaySVTuControl();
            kieu = KieuSoSanh.TheoMSSV;

            bool kqsua = qlsv.Sua(sv, sv.MSSV, SoSanhTheoLoai);

            if (kqsua)
            {
                this.qlsv.GhiFile("dssvtxt.txt");
                this.LoadListView();
            }
            #endregion
        }

        // Xóa sv
        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sinh viên để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa các sinh viên đã chọn?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvSinhVien.CheckedItems)
                {
                    SinhVien sv = item.Tag as SinhVien;

                    if (sv != null)
                    {
                        kieu = KieuSoSanh.TheoMSSV;
                        qlsv.Xoa(sv.MSSV, SoSanhTheoLoai);
                    }
                }

                qlsv.GhiFile("dssvtxt.txt");
                LoadListView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void btnNhapFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Tất cả (*.txt;*.json;*.xml)|*.txt;*.json;*.xml|Text files (*.txt)|*.txt|JSON files (*.json)|*.json|XML files (*.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string ext = Path.GetExtension(path).ToLower();

                txtFilePath.Text = path;

                switch (ext)
                {
                    case ".txt":
                        qlsv.dsSinhVien.Clear(); // Xóa danh sách cũ
                        qlsv.DocTuFile(path);    // Non-static, ghi vào dsSinhVien
                        break;

                    case ".json":
                        qlsv.dsSinhVien = QLSinhVien.DocFileJSON(path); // static, trả về List<SinhVien>
                        break;

                    case ".xml":
                        qlsv.dsSinhVien = QLSinhVien.DocFileXML(path); // static, trả về List<SinhVien>
                        break;

                    default:
                        MessageBox.Show("Định dạng file không được hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Hiển thị danh sách lên ListView
                LoadListView();
            }
        }
    }
}
