using System;
using System.Collections;
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
    public partial class HoaDon : Form
    {
        int hoaDonID;
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        public HoaDon(int id)
        {
            InitializeComponent();
            this.hoaDonID = id;
        }

        private void LoadHoaDonChiTiet()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Thông tin hóa đơn
                string queryInfo = @"
                       SELECT  b.ID,
                               t.Name AS TableName,
                               a.FullName AS NhanVien,
                               b.CheckoutDate,
                               b.Discount,
                               b.Tax,
                               b.Status
                       FROM    Bills b
                       JOIN    [Table] t ON b.TableID = t.ID
                       JOIN    Account a ON b.Account = a.AccountName
                       WHERE   b.ID = @ID";

                SqlCommand cmdInfo = new SqlCommand(queryInfo, conn);
                cmdInfo.Parameters.AddWithValue("@ID", hoaDonID);

                conn.Open();

                decimal discountRate = 0;
                decimal taxRate = 0;

                SqlDataReader reader = cmdInfo.ExecuteReader();
                if (reader.Read())
                {
                    txtMaHoaDon.Text = reader["ID"].ToString();
                    txtTenBan.Text = reader["TableName"].ToString();
                    txtNhanVienLap.Text = reader["NhanVien"].ToString();
                    
                    dtpNgayLap.Value = reader["CheckoutDate"] != DBNull.Value
                        ? Convert.ToDateTime(reader["CheckoutDate"])
                        : DateTime.Now;

                    discountRate = reader["Discount"] != DBNull.Value ? Convert.ToDecimal(reader["Discount"]) : 0;
                    taxRate = reader["Tax"] != DBNull.Value ? Convert.ToDecimal(reader["Tax"]) : 0;

                    txtGiamGia.Text = $"{discountRate:P0}";
                    txtThue.Text = $"{taxRate:P0}";

                    int status = Convert.ToInt32(reader["Status"]);
                    cboTrangThai.Text = status == 1 ? "Đã thanh toán" : "Chưa thanh toán";
                }

                reader.Close();

                // Danh sách món ăn
                string queryFood = @"
                       SELECT  f.FoodName,
                               bd.Quantity,
                               f.Price,
                               (bd.Quantity * f.Price) AS Total
                       FROM    BillDetails bd
                       JOIN    Food f ON bd.FoodID = f.ID
                       WHERE   bd.ID = @ID";

                SqlCommand cmd = new SqlCommand(queryFood, conn);
                cmd.Parameters.AddWithValue("@ID", hoaDonID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvChiTietHoaDon.DataSource = dt;

                // Tổng tiền
                decimal tongTien = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongTien += Convert.ToDecimal(row["Total"]);
                }

                decimal giamGiaTien = tongTien * discountRate; // tiền giảm giá
                decimal thueTien = (tongTien - giamGiaTien) * taxRate; // thuế tính sau khi giảm
                decimal thucThu = tongTien - giamGiaTien + thueTien;

                txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
                txtGiamGia.Text = giamGiaTien.ToString("N0") + " VNĐ";
                txtThue.Text = thueTien.ToString("N0") + " VNĐ";
                txtThucThu.Text = thucThu.ToString("N0") + " VNĐ";

                dgvChiTietHoaDon.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvChiTietHoaDon.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dgvChiTietHoaDon.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvChiTietHoaDon.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDonChiTiet();
        }
    }
}
