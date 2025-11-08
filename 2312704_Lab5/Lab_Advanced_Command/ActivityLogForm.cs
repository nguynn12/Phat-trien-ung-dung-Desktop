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

namespace Lab_Advanced_Command
{
    public partial class ActivityLogForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        public ActivityLogForm()
        {
            InitializeComponent();
        }

        private void LoadOrderDates()
        {
            string query = "EXEC GetOrderDates";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    lstOrderDates.Items.Clear();
                    while (reader.Read())
                    {
                        lstOrderDates.Items.Add(reader.GetDateTime(0).ToShortDateString());
                    }
                }
            }
        }

        private void ActivityLogForm_Load(object sender, EventArgs e)
        {
            LoadOrderDates();
        }

        private void lstOrderDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrderDates.SelectedItem == null)
                return;

            string selectedDate = lstOrderDates.SelectedItem.ToString();
            DataTable dt = new DataTable();
            string query = "EXEC GetOrdersByDate @date";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@date", selectedDate);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            dgvOrderDetails.DataSource = dt;

            string sumQuery = "EXEC GetSummaryByDate @date";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sumQuery, conn))
            {
                cmd.Parameters.AddWithValue("@date", selectedDate);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblTotalOrders.Text = $"Tổng số hóa đơn: {reader.GetInt32(0)}";
                        lblTotalAmount.Text = $"Tổng tiền: {Convert.ToDecimal(reader[1]):N0} VNĐ";
                    }
                }
            }
        }
    }
}
