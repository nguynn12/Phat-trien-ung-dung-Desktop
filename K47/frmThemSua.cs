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

namespace K47
{
    public partial class frmThemSua : Form
    {
        string connectionString = "server=.; database=RestaurantManagement; Integrated Security=true;";

        public int MaBan { get; set; }

        public frmThemSua()
        {
            InitializeComponent();
        }
        
        private void HienThiDuLieu()
        {
            string query = "SELECT * FROM [Table] WHERE ID = @maban";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.Add("@maban", SqlDbType.Int).Value = MaBan;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtMaBan.Text = MaBan.ToString();
                        txtTenBan.Text = reader["Name"].ToString();
                        nudTrangThai.Value = Convert.ToDecimal(reader["Status"]);
                        nudSucChua.Value = Convert.ToDecimal(reader["Capacity"]);
                    }
                }
            }
        }

        private void SuaBan()
        {
            string query = "SuaBan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaBan;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = txtTenBan.Text;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = nudTrangThai.Value;
                cmd.Parameters.Add("@capacity", SqlDbType.Int).Value = nudSucChua.Value;

                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    MessageBox.Show($"Đã cập nhật bàn với id = {MaBan}");
                }
            }
        }

        private void ThemBanThuTuc()
        {
            string query = "ThemBan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = txtTenBan.Text;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = nudTrangThai.Value;

                cmd.Parameters.Add("@capacity", SqlDbType.Int);
                cmd.Parameters["@capacity"].Value = nudSucChua.Value;

                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    int id = Convert.ToInt32(cmd.Parameters["@id"].Value);

                    MessageBox.Show($"Đã thêm bàn với id = {id}");
                }
            }
        }

        private void ThemBanTruyVan()
        {
            string query = @"INSERT INTO [Table]([Name], [Status], [Capacity])
                             VALUES (@name, @status, @cap)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = txtTenBan.Text;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = nudTrangThai.Value;
                cmd.Parameters.Add("@cap", SqlDbType.Int).Value = nudSucChua.Value;

                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Đã thêm bàn thành công!");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text))
            {
                //ThemBanTruyVan();
                ThemBanThuTuc();

                DialogResult = DialogResult.OK;
            }

            else
            {
                SuaBan();

                DialogResult = DialogResult.OK;
            }
        }

        private void frmThemSua_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
