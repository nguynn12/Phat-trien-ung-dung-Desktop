using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QLDVKS_Nhom6
{
    public partial class frmDoanhThu : Form
    {
        // Khai báo BL
        ReportBL reportBL = new ReportBL();
        // Danh sách chứa dữ liệu
        List<RevenueReportItem> listDoanhThu = new List<RevenueReportItem>();

        public frmDoanhThu()
        {
            InitializeComponent();
            // Bỏ các hàm kết nối CSDL
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddDays(-30);
            dtpDenNgay.Value = DateTime.Today;
            cmbKieuThongKe.SelectedIndex = 0;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;
            int groupType = cmbKieuThongKe.SelectedIndex; // 0=Ngày, 1=Tháng, 2=Năm

            // Gọi BL
            listDoanhThu = reportBL.GetRevenue(tuNgay, denNgay, groupType);

            dgvDoanhThu.DataSource = listDoanhThu;

            TinhTongDoanhThu();
        }

        private void TinhTongDoanhThu()
        {
            decimal tong = 0;
            foreach (var item in listDoanhThu)
            {
                tong += item.DoanhThu;
            }
            txtTongDoanhThu.Text = tong.ToString("#,##0") + " VNĐ";
        }

        // KÍCH HOẠT LẠI HÀM XUẤT EXCEL (Dùng CSV)
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (listDoanhThu.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV (Comma delimited)|*.csv",
                Title = "Xuất báo cáo doanh thu",
                FileName = $"DoanhThu_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder csvContent = new StringBuilder();

                    // Thêm tiêu đề
                    csvContent.AppendLine("Ngay/Thang/Nam,So Hoa Don,Doanh Thu");

                    // Thêm dữ liệu
                    foreach (var item in listDoanhThu)
                    {
                        csvContent.AppendLine($"{item.NgayThangNam},{item.SoHoaDon},{item.DoanhThu}");
                    }

                    // Thêm dòng tổng
                    csvContent.AppendLine();
                    csvContent.AppendLine($",Tong Doanh Thu,{txtTongDoanhThu.Text}");

                    // Lưu file (dùng UTF-8 with BOM để Excel đọc đúng tiếng Việt)
                    File.WriteAllText(sfd.FileName, csvContent.ToString(), new UTF8Encoding(true));

                    MessageBox.Show("Xuất file CSV thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message);
                }
            }
        }
    }
}