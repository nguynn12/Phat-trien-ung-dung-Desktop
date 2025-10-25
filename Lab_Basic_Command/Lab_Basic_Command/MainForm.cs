using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Basic_Command
{
    public partial class MainForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";
        int selectedTableID;
        
        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadTrangThai()
        {
            var tableStatus = new Dictionary<int, string>()
            {
                { 0, "Trống" },
                { 1, "Có người" },
                { 2, "Đã đặt" },
                { 3, "Không có sẵn" }
            };

            cboTrangThai.DataSource = new BindingSource(tableStatus, null);
            cboTrangThai.DisplayMember = "Value";
            cboTrangThai.ValueMember = "Key";
            cboTrangThai.SelectedIndex = -1;
        }

        public void LoadTableList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT  ID,
                               Name as TableName,
                               CASE Status
                                    WHEN 0 THEN N'Trống'
                                    WHEN 1 THEN N'Có người'
                                    WHEN 2 THEN N'Đã đặt'
                                    WHEN 3 THEN N'Không có sẵn'
                                    ELSE N'Không xác định'
                                    END AS Status,
                               Capacity
                       FROM    [Table]";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTable.DataSource = dt;
            }
        }

        private void btnLayThongTinBan_Click(object sender, EventArgs e)
        {
            LoadTableList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTrangThai();
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTable.Rows[e.RowIndex];

                txtMaBan.Text = row.Cells["MaBan"].Value.ToString();
                txtTenBan.Text = row.Cells["TenBan"].Value.ToString();
                txtSucChua.Text = row.Cells["SucChua"].Value.ToString();

                string statusText = row.Cells["TrangThai"].Value.ToString();

                var selectedStatus = ((Dictionary<int, string>)((BindingSource)cboTrangThai.DataSource).DataSource)
                             .FirstOrDefault(x => x.Value == statusText).Key;

                cboTrangThai.SelectedValue = selectedStatus;
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO [Table] (Name, Capacity, Status) 
                                 VALUES (@TenBan, @SucChua, @Status)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TenBan", txtTenBan.Text);
                cmd.Parameters.AddWithValue("@SucChua", int.Parse(txtSucChua.Text));
                cmd.Parameters.AddWithValue("@Status", cboTrangThai.SelectedIndex);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã thêm bàn mới thành công!");
                LoadTableList();
            }
        }

        private void btnCapNhatBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text))
            {
                MessageBox.Show("Vui lòng chọn bàn cần cập nhật!", "Thông báo");

                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       UPDATE  [Table]
                       SET     Name = @TenBan,
                               Capacity = @SucChua,
                               Status = @Status
                       WHERE   ID = @Maban";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaBan", int.Parse(txtMaBan.Text));
                cmd.Parameters.AddWithValue("@TenBan", txtTenBan.Text);
                cmd.Parameters.AddWithValue("@SucChua", int.Parse(txtSucChua.Text));
                cmd.Parameters.AddWithValue("@Status", cboTrangThai.SelectedIndex);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cập nhật thông tin bàn thành công!");
                LoadTableList();
            }
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageBox.Show("Vui lòng chọn bàn để xem hóa đơn!", "Thông báo");
                return;
            }

            int maBan = int.Parse(txtMaBan.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT  TOP 1 ID 
                       FROM    Bills 
                       WHERE   TableID = @MaBan AND 
                               [Status] = 1
                       ORDER BY CheckoutDate DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int hoaDonID = Convert.ToInt32(result);

                    HoaDon f = new HoaDon(hoaDonID); 
                    f.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("Bàn này chưa có hóa đơn!", "Thông báo");
                }
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text))
            {
                MessageBox.Show("Vui lòng chọn bàn cần xóa!", "Thông báo");
                return;
            }

            int maBan = int.Parse(txtMaBan.Text);

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa bàn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM [Table] WHERE ID = @MaBan";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaBan", maBan);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đã xóa bàn thành công!", "Thông báo");
                LoadTableList();
            }
        }

        private void dgvTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvTable.ClearSelection();
                dgvTable.Rows[e.RowIndex].Selected = true;
                selectedTableID = Convert.ToInt32(dgvTable.Rows[e.RowIndex].Cells["MaBan"].Value);
            }
        }

        private void contextMenuTable_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string choice = e.ClickedItem.Text;

            switch (choice)
            {
                case "Xoá bàn":
                    XoaBan(selectedTableID);
                    break;

                case "Xem danh mục hóa đơn":
                    DanhMucHoaDonForm f = new DanhMucHoaDonForm(selectedTableID);
                    f.ShowDialog();
                    break;

                case "Xem nhật ký hóa đơn":
                    NhatKyHoaDon f1 = new NhatKyHoaDon(selectedTableID);
                    f1.ShowDialog();
                    break;
                    
            }

        }

        private void XoaBan(int tableID)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa bàn này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM [Table] WHERE ID = @Id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", tableID);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Đã xóa bàn thành công!");
                        LoadTableList();
                    }

                    else
                    {
                        MessageBox.Show("Không thể xóa bàn (có thể còn hóa đơn liên quan).");
                    }
                }
            }
        }

    }
}
