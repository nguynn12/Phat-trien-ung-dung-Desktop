using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing; // Thêm cho PrintDocument

namespace QLDVKS_Nhom6
{
    public partial class frmThanhToan : Form
    {
        // Khai báo BL
        BillBL billBL = new BillBL();
        BillDetailBL billDetailBL = new BillDetailBL();
        ServiceBL serviceBL = new ServiceBL(); // Dùng để tra cứu dịch vụ

        // Dữ liệu của Form
        private int currentBillID = 0;
        private Bill currentBill;
        private List<BillDetail> listChiTiet = new List<BillDetail>();
        private List<Service> listDichVu = new List<Service>(); // Danh sách các dịch vụ
        private decimal tongTien = 0;

        public frmThanhToan() : this(0)
        {
        }

        public frmThanhToan(int billID)
        {
            InitializeComponent();
            this.currentBillID = billID; // Gán BillID vào biến của Form
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadAllDichVu(); // Tải danh sách tất cả dịch vụ (để tra cứu)

            if (this.currentBillID == 0)
            {
                MessageBox.Show("Không có hóa đơn hợp lệ. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Đóng form nếu không có BillID
                return;
            }

            // Tải thông tin
            LoadThongTinDatPhong(); // <== SẼ CHẠY ĐÚNG
            LoadChiTietDichVu(); // <== SẼ CHẠY ĐÚNG
            TinhTongTien();

            // Kích hoạt các nút
            btnThanhToan.Enabled = true;
            btnThemDichVu.Enabled = true;
            btnXoaDichVu.Enabled = true;
        }

        // HÀM MỚI: Cấu hình DataGridView
        private void SetupDataGridView()
        {
            dgvDichVu.AutoGenerateColumns = false;
            // Ánh xạ cột
            colMaDV.DataPropertyName = "BillDetailID"; // Mã chi tiết
            colTenDV.DataPropertyName = "ServiceName";
            colGia.DataPropertyName = "Amount"; // Giá này là THÀNH TIỀN
            colGia.DefaultCellStyle.Format = "N0";
        }

        // HÀM MỚI: Tải danh sách tất cả dịch vụ (để tra cứu)
        private void LoadAllDichVu()
        {
            listDichVu = serviceBL.GetAll();
        }

        #region Thông tin đặt phòng (Sửa)
        private void LoadThongTinDatPhong()
        {
            if (currentBillID == 0) return;

            // GỌI ĐÚNG HÀM BL (Sửa lỗi)
            currentBill = billBL.GetDetailsByID(currentBillID);

            if (currentBill != null)
            {
                txtMaHoaDon.Text = currentBill.BillID.ToString();
                txtMaPhong.Text = currentBill.RoomID == 0 ? "N/A" : currentBill.RoomID.ToString();
                txtTenPhong.Text = currentBill.RoomName;
                txtMaKhachHang.Text = currentBill.CustomerID.ToString();
                txtTenKhachHang.Text = currentBill.FullName;
                dtpNgayDat.Value = currentBill.CheckInDate;
                dtpNgayTra.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Lỗi: Không tìm thấy thông tin hóa đơn!");
                this.Close();
            }
        }
        #endregion

        #region Chi tiết dịch vụ (Sửa)
        private void LoadChiTietDichVu()
        {
            if (currentBillID == 0) return;

            listChiTiet = billDetailBL.GetByBillID(currentBillID); // Gọi BL
            dgvDichVu.DataSource = listChiTiet;
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            if (currentBillID == 0) return;

            int serviceID;
            if (!int.TryParse(txtMaDichVu.Text.Trim(), out serviceID))
            {
                MessageBox.Show("Mã dịch vụ không hợp lệ!");
                return;
            }

            int quantity = 1; // Mặc định số lượng là 1

            var service = listDichVu.Find(s => s.ServiceID == serviceID);
            if (service == null)
            {
                MessageBox.Show("Không tìm thấy dịch vụ với mã này!");
                return;
            }

            // Gọi BL (SP mới sẽ tự tính tiền)
            if (billDetailBL.Insert(currentBillID, serviceID, quantity) > 0)
            {
                MessageBox.Show("Thêm dịch vụ thành công!");
                LoadChiTietDichVu();
                TinhTongTien();
                XoaTrangDichVu();
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại!");
            }
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn dịch vụ để xóa!");
                return;
            }

            if (MessageBox.Show("Xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int billDetailID = (int)dgvDichVu.SelectedRows[0].Cells["colMaDV"].Value;

            if (billDetailBL.Delete(billDetailID) > 0) // Gọi BL
            {
                MessageBox.Show("Xóa thành công!");
                LoadChiTietDichVu();
                TinhTongTien();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
                int billDetailID = (int)row.Cells["colMaDV"].Value;
                BillDetail detail = listChiTiet.Find(d => d.BillDetailID == billDetailID);

                if (detail != null)
                {
                    Service service = listDichVu.Find(s => s.ServiceID == detail.ServiceID);
                    if (service != null)
                    {
                        txtMaDichVu.Text = service.ServiceID.ToString();
                        txtTenDichVu.Text = service.ServiceName;
                        txtGiaDichVu.Text = service.Price.ToString("#,##0");
                    }
                }
            }
        }


        private void XoaTrangDichVu()
        {
            txtMaDichVu.Clear();
            txtTenDichVu.Clear();
            txtGiaDichVu.Clear();
        }
        #endregion

        #region Tính tiền (Sửa)
        private void TinhTongTien()
        {
            tongTien = 0;
            foreach (BillDetail detail in listChiTiet)
            {
                tongTien += detail.Amount;
            }
            txtTongTien.Text = tongTien.ToString("#,##0") + " VNĐ";
        }
        #endregion

        #region Chức năng chính (Sửa)

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            InHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (currentBillID == 0) return;
            if (listChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa có dịch vụ nào, không thể thanh toán!");
                return;
            }

            string xacNhan = $"Xác nhận thanh toán {tongTien:#,##0} VNĐ?";
            if (MessageBox.Show(xacNhan, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (billBL.CheckOut(currentBillID, tongTien) > 0)
                {
                    MessageBox.Show("Thanh toán thành công!");
                    InHoaDon();
                    this.Close(); // Đóng form sau khi thanh toán
                }
                else
                {
                    MessageBox.Show("Lỗi thanh toán!");
                }
            }
        }

        #endregion

        #region In hóa đơn (Sửa)
        private void InHoaDon()
        {
            if (currentBill == null) return; // Đảm bảo đã load bill

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += (s, ev) =>
                {
                    float y = 20;
                    Font title = new Font("Arial", 16, FontStyle.Bold);
                    Font header = new Font("Arial", 12, FontStyle.Bold);
                    Font normal = new Font("Arial", 10);

                    ev.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", title, Brushes.Black, 300, y); y += 40;
                    ev.Graphics.DrawString($"Mã HD: {txtMaHoaDon.Text} | Ngày: {dtpNgayTra.Value:dd/MM/yyyy HH:mm}", normal, Brushes.Black, 50, y); y += 25;
                    ev.Graphics.DrawString($"Khách: {txtTenKhachHang.Text} | Phòng: {txtTenPhong.Text}", normal, Brushes.Black, 50, y); y += 40;

                    ev.Graphics.DrawString("Dịch vụ:", header, Brushes.Black, 50, y); y += 25;

                    foreach (BillDetail detail in listChiTiet)
                    {
                        string ten = detail.ServiceName;
                        string sl = detail.Quantity.ToString();
                        var service = listDichVu.Find(x => x.ServiceID == detail.ServiceID);
                        string gia = (service != null) ? service.Price.ToString("#,##0") : "N/A";
                        string tt = detail.Amount.ToString("#,##0");

                        ev.Graphics.DrawString($"{ten} x{sl} (Đơn giá: {gia}) = {tt} VNĐ", normal, Brushes.Black, 70, y); y += 20;
                    }

                    y += 10;
                    ev.Graphics.DrawString($"TỔNG TIỀN: {tongTien:#,##0} VNĐ", header, Brushes.Black, 300, y);
                };
                doc.Print();
            }
        }

        #endregion

        // Xóa các hàm điều hướng
    }
}