using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312704_TaNhatNguyen_De02
{
    public partial class frmQLNCC : Form
    {
        QuanLyNCC qlncc = new QuanLyNCC();

        KieuSoSanh kieu;

        public frmQLNhapHang fQLNhapHang { get; set; }

        public frmQLNCC()
        {
            InitializeComponent();
        }

        private NhaCungCap LayTuControl()
        {
            NhaCungCap ncc = new NhaCungCap();

            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.SDT = mtxtSDT.Text;
            ncc.MoTa = txtMoTa.Text;

            return ncc;
        }

        private NhaCungCap LayTuLV(ListViewItem lvitem)
        {
            NhaCungCap ncc = new NhaCungCap();

            ncc.MaNCC = lvitem.SubItems[0].Text;
            ncc.TenNCC = lvitem.SubItems[1].Text;
            ncc.DiaChi = lvitem.SubItems[2].Text;
            ncc.SDT = lvitem.SubItems[3].Text;
            ncc.MoTa = lvitem.SubItems[4].Text;

            return ncc;
        }

        private void XuatTrenControl(NhaCungCap ncc)
        {
            txtMaNCC.Text = ncc.MaNCC;
            txtTenNCC.Text = ncc.TenNCC;
            txtDiaChi.Text = ncc.DiaChi;
            mtxtSDT.Text = ncc.SDT;
            txtMoTa.Text = ncc.MoTa;
        }

        private void XuatTrenLV(NhaCungCap ncc)
        {
            ListViewItem lvitem = new ListViewItem(ncc.MaNCC);
            lvitem.SubItems.Add(ncc.TenNCC);
            lvitem.SubItems.Add(ncc.DiaChi);
            lvitem.SubItems.Add(ncc.SDT);
            lvitem.SubItems.Add(ncc.MoTa);

            lvNCC.Items.Add(lvitem);
        }

        public string LayTen(NhaCungCap ncc)
        {
            return ncc.TenNCC;
        }

        private int SoSanhTheoLoai(object ncc1, object ncc2)
        {
            NhaCungCap ncc = ncc2 as NhaCungCap;

            if (kieu == KieuSoSanh.TheoMa)

                return ncc.MaNCC.CompareTo(ncc1);

            if (kieu == KieuSoSanh.TheoTen)

                return ncc.TenNCC.CompareTo(ncc1);

            return ncc.SDT.CompareTo(ncc1);
        }

        private void LoadListView()
        {
            lvNCC.Items.Clear();

            foreach (NhaCungCap ncc in qlncc.dsNhaCC)
            {
                XuatTrenLV(ncc);
            }
        }

        private void frmQLNCC_Load(object sender, EventArgs e)
        {
            qlncc = new QuanLyNCC();

            qlncc.dsNhaCC = DocFile.DocJson("data.json");

            LoadListView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Nếu có dữ liệu -> cập nhật
            if (!string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                NhaCungCap nccmoi = LayTuControl();

                kieu = KieuSoSanh.TheoMa;

                bool kq = qlncc.Sua(nccmoi, nccmoi.MaNCC, SoSanhTheoLoai);

                if (kq)
                {
                    LoadListView();
                }
            }

            // Nếu không có dữ liệu -> Thêm
            // Lấy mã người cuối cùng + 1 là mã người mới thêm
            else
            {
                int maMoi = 1; // Mặc định là 1 nếu không lấy dữ liệu mẫu;

                if (lvNCC.Items.Count > 0)
                {
                    NhaCungCap cuoi = qlncc.dsNhaCC[qlncc.dsNhaCC.Count - 1];

                    int ma = int.Parse(cuoi.MaNCC);

                    maMoi = ma + 1;
                }

                NhaCungCap ncc = LayTuControl();

                ncc.MaNCC = maMoi.ToString();

                if (string.IsNullOrWhiteSpace(ncc.MaNCC) ||
                    string.IsNullOrWhiteSpace(ncc.DiaChi) ||
                    string.IsNullOrWhiteSpace(ncc.SDT) ||
                    string.IsNullOrWhiteSpace(ncc.MoTa))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }

                else
                {
                    qlncc.Them(ncc);
                    LoadListView();
                } 
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "File Xml (*.xml)|*.xml";
            sfd.Title = "Chọn nơi lưu file";
            sfd.FileName = "danhsach.xml";

            NhaCungCap ncc = new NhaCungCap();

            List<NhaCungCap> kq = new List<NhaCungCap>();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem lvitem in lvNCC.Items)
                {
                    ncc = LayTuLV(lvitem);

                    kq.Add(ncc);
                }

                DocFile.GhiXml(sfd.FileName, kq);

                MessageBox.Show("Xuất file thành công!");
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            mtxtSDT.Text = "";
            txtMoTa.Text = "";

            if (rdTheoSDT.Checked)
            {
                rdTheoTen.Checked = true;
                rdTheoSDT.Checked = false;
            }
        }

        private void lvNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvNCC.SelectedItems.Count;

            if (count > 0)
            {
                ListViewItem lvitem = lvNCC.SelectedItems[0];
                NhaCungCap ncc = LayTuLV(lvitem);
                XuatTrenControl(ncc);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tim = txtTimKiem.Text;

            if (!string.IsNullOrWhiteSpace(tim))
            {
                LoadListView();

                return;
            }

            lvNCC.Items.Clear();

            if (rdTheoSDT.Checked)
            {
                var kq = qlncc.dsNhaCC
                              .Where(ncc => ncc.SDT.Contains(tim))
                              .ToList();

                foreach (NhaCungCap ncc in kq)
                {
                    XuatTrenLV(ncc);
                }
                
            }

            if (rdTheoTen.Checked)
            {
                var kq = qlncc.dsNhaCC
                              .Where(ncc => ncc.TenNCC.Contains(tim))
                              .ToList();

                foreach (NhaCungCap ncc in kq)
                {
                    XuatTrenLV(ncc);
                }
            } 
        }

        private void lvNCC_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvitem = lvNCC.SelectedItems[0];
            NhaCungCap ncc = LayTuLV(lvitem);

            this.Close();
        }
    }
}
