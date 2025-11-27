using BusinessLogic;
using DataAccess; // Cần dùng để tham chiếu đến class 'Room' và 'Customer'
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLDVKS_Nhom6
{
    public partial class frmPhongKH : Form
    {
        // Danh sách để chứa dữ liệu (thay cho DataTable)
        List<Room> listPhong = new List<Room>();
        List<Customer> listKhachHang = new List<Customer>();

        // Khởi tạo các lớp BL
        RoomBL roomBL = new RoomBL();
        CustomerBL customerBL = new CustomerBL();

        public frmPhongKH()
        {
            InitializeComponent();
            // KHÔNG cần KetNoiCSDL() hay KhoiTaoBang() nữa
        }

        private void frmPhongKH_Load(object sender, EventArgs e)
        {
            // Cấu hình DataGridView (Rất quan trọng)
            SetupDataGridViews();

            LoadPhong();
            LoadKhachHang();
            // LoadComboPhong() sẽ dùng chung dữ liệu của LoadPhong()
        }

        private void SetupDataGridViews()
        {
            dgvPhong.AutoGenerateColumns = false;
            dgvKhachHang.AutoGenerateColumns = false;

            // Ánh xạ cột dgvPhong
            dgvPhong.Columns["colRoomID"].DataPropertyName = "RoomID";
            dgvPhong.Columns["colRoomNameRoom"].DataPropertyName = "RoomName";
            dgvPhong.Columns["colStatus"].DataPropertyName = "StatusID";

            // Ánh xạ cột dgvKhachHang
            dgvKhachHang.Columns["colCustomerID"].DataPropertyName = "CustomerID";
            dgvKhachHang.Columns["colFullName"].DataPropertyName = "FullName";
            dgvKhachHang.Columns["colPhone"].DataPropertyName = "Phone";
            dgvKhachHang.Columns["colAddress"].DataPropertyName = "Address";
            dgvKhachHang.Columns["colRoomName"].DataPropertyName = "RoomName";
        }

        #region Phòng
        private void LoadPhong()
        {
            listPhong = roomBL.GetAll(); // Gọi BL
            dgvPhong.DataSource = listPhong;

            // Nạp ComboBox từ danh sách vừa tải
            LoadComboPhong(listPhong);
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenPhong.Text.Trim()))
            {
                MessageBox.Show("Nhập tên phòng!");
                return;
            }

            Room room = new Room();
            room.RoomName = txtTenPhong.Text.Trim();
            room.StatusID = 1; // SỬA: Logic mới, 1 = Trống

            if (roomBL.Insert(room) > 0)
            {
                MessageBox.Show("Thêm phòng thành công!");
                LoadPhong(); // Tải lại cả grid và combo
                XoaTrangPhong();
            }
            else
            {
                MessageBox.Show("Thêm phòng thất bại!");
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0) return;

            // Lấy RoomID từ Grid (DataBoundItem)
            int selectedRoomID = (int)dgvPhong.SelectedRows[0].Cells["colRoomID"].Value;
            Room room = listPhong.Find(r => r.RoomID == selectedRoomID);

            if (room == null) return;

            room.RoomName = txtTenPhong.Text.Trim();
            // Lưu ý: Giao diện của bạn không cho phép sửa trạng thái,
            // nên chúng ta chỉ cập nhật tên.

            if (roomBL.Update(room) > 0)
            {
                MessageBox.Show("Sửa phòng thành công!");
                LoadPhong();
            }
            else
            {
                MessageBox.Show("Sửa phòng thất bại!");
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int selectedRoomID = (int)dgvPhong.SelectedRows[0].Cells["colRoomID"].Value;
            Room room = new Room() { RoomID = selectedRoomID };

            try
            {
                if (roomBL.Delete(room) > 0)
                {
                    MessageBox.Show("Xóa phòng thành công!");
                    LoadPhong();
                    XoaTrangPhong();
                }
                else
                {
                    MessageBox.Show("Xóa phòng thất bại!");
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi nếu xóa phòng đang có khách
                MessageBox.Show("Lỗi: Không thể xóa phòng này. " + ex.Message);
            }
        }


        private void XoaTrangPhong()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
        }
        #endregion

        #region Khách hàng
        private void LoadKhachHang()
        {
            listKhachHang = customerBL.GetAll(); // Gọi BL
            dgvKhachHang.DataSource = listKhachHang;
        }

        private void LoadComboPhong(List<Room> rooms)
        {
            cmbPhong.Items.Clear();
            // Thêm lựa chọn "Không có phòng" (cho khách vãng lai)
            cmbPhong.Items.Add(new { Text = "(Không chọn phòng)", Value = (int?)null });

            foreach (var room in rooms)
            {
                // Chỉ thêm phòng trống vào combo
                if (room.StatusID == 1) // 1 = Trống
                {
                    cmbPhong.Items.Add(new { Text = room.RoomName, Value = (int?)room.RoomID });
                }
            }
            cmbPhong.DisplayMember = "Text";
            cmbPhong.ValueMember = "Value";
            cmbPhong.SelectedIndex = 0; // Mặc định là "(Không chọn phòng)"
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhachHang.Text.Trim()))
            {
                MessageBox.Show("Nhập tên khách!");
                return;
            }

            Customer customer = new Customer();
            customer.FullName = txtTenKhachHang.Text.Trim();
            customer.Phone = txtSoDienThoai.Text.Trim();
            customer.Address = txtDiaChi.Text.Trim();

            // Lấy RoomID (có thể null) từ ComboBox
            customer.RoomID = ((dynamic)cmbPhong.SelectedItem).Value;

            if (customerBL.Insert(customer) > 0)
            {
                MessageBox.Show("Thêm khách thành công!");
                LoadKhachHang();
                XoaTrangKH();
            }
            else
            {
                MessageBox.Show("Thêm khách thất bại!");
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0) return;

            // Lấy CustomerID
            int selectedCustomerID = (int)dgvKhachHang.SelectedRows[0].Cells["colCustomerID"].Value;

            Customer customer = new Customer();
            customer.CustomerID = selectedCustomerID; // ID là bắt buộc
            customer.FullName = txtTenKhachHang.Text.Trim();
            customer.Phone = txtSoDienThoai.Text.Trim();
            customer.Address = txtDiaChi.Text.Trim();
            customer.RoomID = ((dynamic)cmbPhong.SelectedItem).Value;

            if (customerBL.Update(customer) > 0)
            {
                MessageBox.Show("Sửa khách thành công!");
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Sửa khách thất bại!");
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Xóa khách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int selectedCustomerID = (int)dgvKhachHang.SelectedRows[0].Cells["colCustomerID"].Value;
            Customer customer = new Customer() { CustomerID = selectedCustomerID };

            try
            {
                if (customerBL.Delete(customer) > 0)
                {
                    MessageBox.Show("Xóa khách thành công!");
                    LoadKhachHang();
                    XoaTrangKH();
                }
                else
                {
                    MessageBox.Show("Xóa khách thất bại!");
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi nếu xóa khách đang có hóa đơn
                MessageBox.Show("Lỗi: Không thể xóa khách hàng này. " + ex.Message);
            }
        }


        private void XoaTrangKH()
        {
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            cmbPhong.SelectedIndex = 0;
        }
        #endregion

        private void dgvPhong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra cột "colStatus"
            if (dgvPhong.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                // Thêm kiểm tra kiểu dữ liệu an toàn
                if (e.Value is int)
                {
                    int statusID = (int)e.Value;
                    switch (statusID)
                    {
                        case 1:
                            e.Value = "Trống";
                            break;
                        case 2:
                            e.Value = "Đã đặt";
                            break;
                        case 3:
                            e.Value = "Đang dọn";
                            break;
                        default:
                            e.Value = "Không rõ";
                            break;
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells["colRoomID"].Value.ToString();
                txtTenPhong.Text = row.Cells["colRoomNameRoom"].Value.ToString();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells["colCustomerID"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["colFullName"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["colPhone"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["colAddress"].Value?.ToString() ?? "";

                string roomName = row.Cells["colRoomName"].Value?.ToString();
                if (!string.IsNullOrEmpty(roomName))
                {
                    // Tìm phòng trong CBB
                    for (int i = 0; i < cmbPhong.Items.Count; i++)
                    {
                        if (((dynamic)cmbPhong.Items[i]).Text == roomName)
                        {
                            cmbPhong.SelectedIndex = i;
                            return;
                        }
                    }
                    // Nếu không tìm thấy (vì phòng đã có khách)
                    cmbPhong.SelectedIndex = 0;
                }
                else
                {
                    // Khách không có phòng
                    cmbPhong.SelectedIndex = 0;
                }
            }
        }

    }
}