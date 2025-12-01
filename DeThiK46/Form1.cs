using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThiK46
{
    public partial class Form1 : Form
    {
        string connectionString = "server=.; database=QLDKHP; Integrated Security = true;";
        public string MaMH { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        // Ham load chuong trinh dao tao vao combobox
        private void LoadCTDT()
        {
            string query = @"SELECT MaCTDT, TenCTDT, MoTa
                            FROM    ChuongTrinhDT";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbbCTDT.DataSource = dt;
                cbbCTDT.DisplayMember = "TenCTDT";
                cbbCTDT.ValueMember = "MaCTDT";
            }
        }

        // Ham them mon hoc
        private void ThemMonHoc()
        {
            string query = "EXEC ThemMonHoc @mamh, @tenmh, @sotc, @mactdt";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.Add("@mamh", SqlDbType.NChar, 10).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50).Value = txtTenMH.Text;
                cmd.Parameters.Add("@sotc", SqlDbType.Int).Value = Convert.ToInt32(nudSoTC.Value);

                if (cbbCTDT.SelectedValue is DataRowView)
                {
                    DataRowView rowView = cbbCTDT.SelectedValue as DataRowView;

                    cmd.Parameters.Add("@mactdt", SqlDbType.Int).Value = rowView["MaCTDT"];
                }

                else
                    cmd.Parameters.Add("@mactdt", SqlDbType.Int).Value = cbbCTDT.SelectedValue;

                int rowEffected = cmd.ExecuteNonQuery();

                if (rowEffected > 0)
                {
                    MessageBox.Show($"Da them mon hoc");
                }
            }
        }

        // Ham cap nhat mon hoc
        private void CapNhatMonHoc()
        {
            string query = @"
            UPDATE  MonHoc
            SET     TenMH = @tenmh,
                    SoTC = @sotc,
                    MaCTĐT = @mactdt
            WHERE   MaMH = @mamh";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50).Value = txtTenMH.Text.Trim();
                cmd.Parameters.Add("@sotc", SqlDbType.Int).Value = Convert.ToInt32(nudSoTC.Value);
                
                if (cbbCTDT.SelectedValue is DataRowView)
                {
                    DataRowView rowView = cbbCTDT.SelectedValue as DataRowView;

                    cmd.Parameters.Add("@mactdt", SqlDbType.Int).Value = rowView["MaCTDT"];
                }

                else
                    cmd.Parameters.Add("@mactdt", SqlDbType.Int).Value = cbbCTDT.SelectedValue;

                cmd.Parameters.Add("@mamh", SqlDbType.NChar, 10).Value = MaMH.Trim();

                int rowEffected = cmd.ExecuteNonQuery();

                if (rowEffected > 0)
                {
                    MessageBox.Show("Cap nhat thanh cong");
                }
            }
        }

        // Ham lay du lieu tu frmQLMH dua vao control
        private void HienThiDuLieu()
        {
            if (!string.IsNullOrWhiteSpace(MaMH))
            {
                string query = @"
                       SELECT	MaMH, TenMH, SoTC, ct.TenCTDT, MaCTDT
                       FROM	MonHoc mh
                       JOIN	ChuongTrinhDT ct ON mh.MaCTĐT = ct.MaCTDT
                       WHERE	MaMH = @mamh";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.Add("@mamh", SqlDbType.NChar, 10);
                    cmd.Parameters["@mamh"].Value = MaMH.Trim();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMaMH.Text = MaMH;
                            txtTenMH.Text = reader["TenMH"].ToString();
                            nudSoTC.Value = Convert.ToInt32(reader["SoTC"]);
                            cbbCTDT.SelectedValue = reader["MaCTDT"];
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCTDT();
            HienThiDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                ThemMonHoc();

                DialogResult = DialogResult.OK;
            }

            else
            {
                CapNhatMonHoc();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
