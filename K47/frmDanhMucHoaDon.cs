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
    public partial class frmDanhMucHoaDon : Form
    {
        string connectionString = "server=.; database =RestaurantManagement; Integrated Security=true;";

        public int MaBan { get; set; }

        public frmDanhMucHoaDon()
        {
            InitializeComponent();
        }

        private void LoadNgayLapHD()
        {
            string query = "SELECT * FROM dbo.LayDSNgayLap(@id)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaBan;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lbNgayHD.Items.Add(reader["CheckoutDate"].ToString());
                    }
                }
            }
        }

        private void LoadCTHD()
        {
            string query = "XemCTHD";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                cmd.CommandType = CommandType.StoredProcedure;

                DateTime ngayDcChon = Convert.ToDateTime(lbNgayHD.SelectedItem.ToString());

                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = ngayDcChon;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = MaBan;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvChiTietHD.DataSource = dt;
                }
            }
        }

        private void frmDanhMucHoaDon_Load(object sender, EventArgs e)
        {
            LoadNgayLapHD();
        }

        private void lbNgayHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNgayHD.SelectedIndex == -1) return;

            LoadCTHD();
        }
    }
}
