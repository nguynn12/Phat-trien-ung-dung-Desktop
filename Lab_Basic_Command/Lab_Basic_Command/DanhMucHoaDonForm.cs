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
    public partial class DanhMucHoaDonForm : Form
    {
        private class ListItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";
        int tableID;

        public DanhMucHoaDonForm(int tableID)
        {
            InitializeComponent();
            this.tableID = tableID;
        }

        public void LoadDanhSachHoaDon()
        {
            lbNgayLap.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT  ID,
                               CheckoutDate
                       FROM    Bills
                       WHERE   TableID = @TableID
                       ORDER BY CheckoutDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TableID", tableID);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string date = reader["CheckoutDate"] != DBNull.Value
                        ? Convert.ToDateTime(reader["CheckoutDate"]).ToString("dd/MM/yyyy HH:mm")
                        : "(Chưa thanh toán)";

                    lbNgayLap.Items.Add(new ListItem
                    {
                        Text = date,
                        Value = Convert.ToInt32(reader["ID"])
                    });
                }
                reader.Close();
            }
        }

        public void LoadChiTietHoaDon(int hoaDonID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT  f.FoodName,
                               bd.Quantity,
                               f.Price,
                               (bd.Quantity * f.Price) AS Total
                       FROM    BillDetails bd
                       JOIN    Food f ON bd.FoodID = f.ID
                       WHERE   bd.ID = @HoaDonID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvChiTietHoaDon.DataSource = dt;
                dgvChiTietHoaDon.ClearSelection();
            }
        }

        private void DanhMucHoaDonForm_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void lbNgayLap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNgayLap.SelectedItem is ListItem selected)
            {
                int hoaDonID = (int)selected.Value;
                LoadChiTietHoaDon(hoaDonID);
            }
        }
    }
}
