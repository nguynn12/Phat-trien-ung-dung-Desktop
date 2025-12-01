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
    public partial class Form1 : Form
    {
        string connectionString = "server=.;  database=RestaurantManagement; Integrated Security = true;";

        public Form1()
        {
            InitializeComponent();
        }

        private string XacDinhTrangThai(int trangThai)
        {
            switch (trangThai)
            {
                case 0: return "Trống";
                case 1: return "Có người";
                case 2: return "Đã đặt";
                default: return "";
            }
        }

        private Color XacDinhMau(int trangThai)
        {
            switch (trangThai)
            {
                case 0: return Color.LightGreen;
                case 1: return Color.Yellow;
                case 2: return Color.Red;
                default: return Color.White;
            }
        }

        private void LoadBan()
        {
            string query = "SELECT * FROM [Table]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            //Combo Box, DataGridView, FlowLayoutPanel

            //ListView, CheckedListBox -> SqlDataReader

            //Them, Xóa, Sửa -> ExecuteNonQuery + Đưa parameter

            //Thống kê -> ExecuteNonQuery

            //Đếm, Tính tổng, Max, Min -> ExecuteScalar
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();

                da.Fill(dt);

                flpDSBan.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Button btn = new Button();
                    btn.Width = 80;
                    btn.Height = 80;

                    int trangThai = (int)row["Status"];
                    string tenBan = row["Name"].ToString();

                    btn.Text = $"Bàn {tenBan}\n{XacDinhTrangThai(trangThai)}";
                    btn.BackColor = XacDinhMau(trangThai);
                    btn.Tag = row["ID"];

                    btn.Click += Button_Click;
                    btn.MouseDown += Button_RightClick;

                    flpDSBan.Controls.Add(btn);
                }
            }
        }

        private void XoaBan(int id)
        {
            string query = "XoaBan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                int rowAffected = cmd.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    MessageBox.Show($"Đã xóa bàn có id = {id}");
                }
            }
        }

        private void HienThiHoaDon(int id)
        {
            string query = "XemHoaDon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                lvHoaDon.Items.Clear();

                conn.Open();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem lvitem = new ListViewItem(reader["TenMonAn"].ToString());

                        lvitem.SubItems.Add(reader["DVT"].ToString());
                        lvitem.SubItems.Add(reader["SoLuong"].ToString());
                        lvitem.SubItems.Add(reader["DonGia"].ToString());
                        lvitem.SubItems.Add(reader["ThanhTien"].ToString());

                        lvHoaDon.Items.Add(lvitem);
                    }
                }
            }
        }

        private void Button_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Cho biết nút nào được ấn vào
                Button btn = sender as Button;
                flpDSBan.Tag = btn.Tag;
                cmsDanhMuc.Show(Cursor.Position);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            flpDSBan.Tag = btn.Tag;

            int id = (int)flpDSBan.Tag;

            HienThiHoaDon(id);
        }

        private void Button_DoubleClick(object sender, EventArgs e)
        {
            btnLuu.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmThemSua form = new frmThemSua();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBan();
            }
        }

        private void tsmCapNhat_Click(object sender, EventArgs e)
        {
            int id = (int)flpDSBan.Tag;

            frmThemSua form = new frmThemSua();

            form.MaBan = id;

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBan();
            }
        }

        private void tsmXoaBan_Click(object sender, EventArgs e)
        {
            int id = (int)flpDSBan.Tag;

            XoaBan(id);

            LoadBan();
        }

        private void tsmXemHoaDon_Click(object sender, EventArgs e)
        {
            int id = (int)flpDSBan.Tag;

            frmDanhMucHoaDon form = new frmDanhMucHoaDon();

            form.MaBan = id;

            form.ShowDialog(this);
        }
    }
}
