using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Globalization; // Thêm
using System.Linq;
using System.Text; // Thêm
using System.Windows.Forms;

namespace QLDVKS_Nhom6
{
    public partial class frmChinh : Form
    {
        List<Service> listDichVu = new List<Service>();
        List<ServiceType> listLoaiDV = new List<ServiceType>();
        Service dichVuCurrent = new Service();
        List<ActiveServiceUsage> listKHSD_DV = new List<ActiveServiceUsage>();

        public frmChinh()
        {
            InitializeComponent();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            // Sửa: Gọi hàm SetupDGV trước
            SetupDataGridViews();
            LoadDichVu();
            LoadLoaiDichVu();
            LoadKHSDDichVu();
        }

        // HÀM MỚI: Dùng để cấu hình DGV (Sửa lỗi B.1)
        private void SetupDataGridViews()
        {
            // Panel 1: Dịch vụ
            dgvDichVu.AutoGenerateColumns = false;
            ServiceID.DataPropertyName = "ServiceID";
            ServiceName.DataPropertyName = "ServiceName";
            TypeName.DataPropertyName = "TypeName";
            Price.DataPropertyName = "Price";
            Price.DefaultCellStyle.Format = "N0"; // Định dạng số

            // Panel 2: Khách hàng SDDV
            dgvKHSDDichVu.AutoGenerateColumns = false;
            MaKH.DataPropertyName = "CustomerID";
            TenKH.DataPropertyName = "FullName";
            LoaiDVSD.DataPropertyName = "TypeName";
            dataGridViewTextBoxColumn2.DataPropertyName = "ServiceName";
            SoLuongDV.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            dataGridViewTextBoxColumn3.DefaultCellStyle.Format = "N0";
            NgaySD.DataPropertyName = "CheckInDate"; // Sửa lỗi typo "CheckinDate"
            TongTien.DataPropertyName = "Amount";
            TongTien.DefaultCellStyle.Format = "N0";
        }

        private void LoadKHSDDichVu()
        {
            BillDetailBL bl = new BillDetailBL();
            listKHSD_DV = bl.GetActiveUsage();
            dgvKHSDDichVu.DataSource = listKHSD_DV;
        }

        #region Dịch vụ
        private void LoadDichVu()
        {
            ServiceBL serviceBL = new ServiceBL();
            listDichVu = serviceBL.GetAll();
            dgvDichVu.DataSource = listDichVu;
        }

        private void LoadLoaiDichVu()
        {
            ServiceTypeBL typeBL = new ServiceTypeBL();
            listLoaiDV = typeBL.GetAll();

            cboLoaiDV.Items.Clear();
            cboLocDV.Items.Clear();
            cboLocDV.Items.Add("Tất cả");

            foreach (var type in listLoaiDV)
            {
                cboLoaiDV.Items.Add(new { Text = type.TypeName, Value = type.ServiceTypeID });
                cboLocDV.Items.Add(type.TypeName);
            }

            cboLoaiDV.DisplayMember = "Text";
            cboLoaiDV.ValueMember = "Value";
            cboLocDV.SelectedIndex = 0;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDV.Text.Trim()) || cboLoaiDV.SelectedItem == null)
            {
                MessageBox.Show("Nhập đầy đủ tên và loại dịch vụ!");
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtGia.Text.Trim(), out price))
            {
                MessageBox.Show("Giá dịch vụ không hợp lệ. Vui lòng chỉ nhập số.");
                return;
            }

            Service s = new Service
            {
                ServiceID = 0,
                ServiceName = txtTenDV.Text.Trim(),
                Price = price, // SỬA LỖI: Dùng biến "price" đã TryParse
                ServiceTypeID = ((dynamic)cboLoaiDV.SelectedItem).Value
            };

            ServiceBL bl = new ServiceBL();
            if (bl.Insert(s) > 0)
            {
                MessageBox.Show("Thêm dịch vụ thành công!");
                LoadDichVu();
                XoaTrangDV();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count == 0 || dichVuCurrent == null)
            {
                MessageBox.Show("Chọn dịch vụ cần sửa!");
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtGia.Text.Trim(), out price))
            {
                MessageBox.Show("Giá dịch vụ không hợp lệ. Vui lòng chỉ nhập số.");
                return;
            }

            dichVuCurrent.ServiceName = txtTenDV.Text.Trim();
            dichVuCurrent.Price = price; // SỬA LỖI: Dùng biến "price" đã TryParse
            dichVuCurrent.ServiceTypeID = ((dynamic)cboLoaiDV.SelectedItem).Value;

            ServiceBL bl = new ServiceBL();
            if (bl.Update(dichVuCurrent) > 0)
            {
                MessageBox.Show("Sửa thành công!");
                LoadDichVu();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Tìm dịch vụ (an toàn hơn)
                int serviceId = (int)dgvDichVu.Rows[e.RowIndex].Cells["ServiceID"].Value;
                dichVuCurrent = listDichVu.FirstOrDefault(s => s.ServiceID == serviceId);

                if (dichVuCurrent == null) return;

                txtMaDV.Text = dichVuCurrent.ServiceID.ToString();
                txtTenDV.Text = dichVuCurrent.ServiceName;
                txtGia.Text = dichVuCurrent.Price.ToString();

                int typeID = dichVuCurrent.ServiceTypeID;
                for (int i = 0; i < cboLoaiDV.Items.Count; i++)
                {
                    if (((dynamic)cboLoaiDV.Items[i]).Value == typeID)
                    {
                        cboLoaiDV.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void XoaTrangDV()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtGia.Clear();
            cboLoaiDV.SelectedIndex = -1;
            dgvDichVu.ClearSelection();
            dichVuCurrent = null; // Quan trọng
        }

        // HÀM MỚI: Bỏ dấu tiếng Việt để tìm kiếm
        public static string RemoveAccents(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Normalize(NormalizationForm.FormD);
            char[] chars = text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
            return new string(chars).Normalize(NormalizationForm.FormC);
        }

        private void theoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.DataSource == null) return;
            var list = (List<Service>)dgvDichVu.DataSource;
            var sortedList = list.OrderBy(s => s.ServiceName).ToList();
            dgvDichVu.DataSource = sortedList;
        }

        private void theoGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.DataSource == null) return;
            var list = (List<Service>)dgvDichVu.DataSource;
            var sortedList = list.OrderBy(s => s.Price).ToList();
            dgvDichVu.DataSource = sortedList;
        }

        private void btnTimDV_Click(object sender, EventArgs e)
        {
            // SỬA (REQUEST 2): Tìm không dấu, không hoa/thường
            string ten = RemoveAccents(txtTenDV.Text.Trim().ToLower());
            string loai = cboLocDV.SelectedIndex > 0 ? cboLocDV.Text : "";

            var result = listDichVu.AsEnumerable();

            if (!string.IsNullOrEmpty(ten))
            {
                result = result.Where(s => RemoveAccents(s.ServiceName.ToLower()).Contains(ten));
            }
            if (!string.IsNullOrEmpty(loai))
                result = result.Where(s => listLoaiDV.Find(t => t.ServiceTypeID == s.ServiceTypeID)?.TypeName == loai);

            dgvDichVu.DataSource = result.ToList();
        }
        #endregion

        // (Code Sắp xếp Panel 2 giữ nguyên)
        private void theoGiáToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvKHSDDichVu.DataSource == null) return;
            var list = (List<ActiveServiceUsage>)dgvKHSDDichVu.DataSource;
            var sortedList = list.OrderBy(x => x.Price).ToList();
            dgvKHSDDichVu.DataSource = sortedList;
        }

        private void theoTổngTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKHSDDichVu.DataSource == null) return;
            var list = (List<ActiveServiceUsage>)dgvKHSDDichVu.DataSource;
            var sortedList = list.OrderBy(x => x.Amount).ToList();
            dgvKHSDDichVu.DataSource = sortedList;
        }

        private void theoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKHSDDichVu.DataSource == null) return;
            var list = (List<ActiveServiceUsage>)dgvKHSDDichVu.DataSource;
            var sortedList = list.OrderBy(x => x.CheckInDate).ToList();
            dgvKHSDDichVu.DataSource = sortedList;
        }

        private void theoSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKHSDDichVu.DataSource == null) return;
            var list = (List<ActiveServiceUsage>)dgvKHSDDichVu.DataSource;
            var sortedList = list.OrderBy(x => x.Quantity).ToList();
            dgvKHSDDichVu.DataSource = sortedList;
        }

        // XÓA (REQUEST 4): Hàm lọc "theoLoaiToolStripMenuItem_Click"
        // XÓA (REQUEST 4): Hàm lọc "theoNgàyToolStripMenuItem1_Click"

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtMaKH.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvKHSDDichVu.DataSource = listKHSD_DV;
                return;
            }

            var result = listKHSD_DV.AsEnumerable();

            if (rdTheoMaKH.Checked)
            {
                result = result.Where(x => x.CustomerID.ToString().Contains(keyword));
            }
            else if (rdTheoTenKH.Checked)
            {
                result = result.Where(x => x.FullName.ToLower().Contains(keyword));
            }
            else if (rdtheoTenDV.Checked)
            {
                result = result.Where(x => x.ServiceName.ToLower().Contains(keyword));
            }

            dgvKHSDDichVu.DataSource = result.ToList();
        }

        private void dgvKHSDDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKHSDDichVu.Columns[e.ColumnIndex].Name == "ThanhToan")
            {
                int billID = listKHSD_DV[e.RowIndex].BillID;
                frmThanhToan f = new frmThanhToan(billID);
                f.ShowDialog();
                LoadKHSDDichVu();
                LoadDichVu();
            }
        }

        // THÊM (REQUEST 1): Lọc khi ComboBox thay đổi
        private void cboLocDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tự động lọc khi thay đổi lựa chọn
            btnTimDV_Click(sender, e);
        }

        // THÊM (REQUEST 3): Thay đổi Label khi chọn RadioButton
        private void rdTheoMaKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTheoMaKH.Checked)
                lblTim.Text = "Mã KH:";
        }

        private void rdTheoTenKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTheoTenKH.Checked)
                lblTim.Text = "Tên KH:";
        }

        private void rdtheoTenDV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtheoTenDV.Checked)
                lblTim.Text = "Tên DV:";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadKHSDDichVu();

            txtMaKH.Text = "";
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}