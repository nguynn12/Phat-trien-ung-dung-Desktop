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
    public partial class OdersForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        public OdersForm()
        {
            InitializeComponent();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            string query = "EXEC GetOrdersByDateRange @fromDate, @toDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fromDate", from);
                    cmd.Parameters.AddWithValue("@toDate", to);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOrders.DataSource = dt;
                    }
                }

                LoadSummary(from, to);
            }
        }

        private void LoadSummary(DateTime from, DateTime to)
        {
            string query = "EXEC GetOrderSummary @fromDate, @toDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fromDate", from);
                    cmd.Parameters.AddWithValue("@toDate", to);

                    conn.Open();
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTotal.Text = reader["Total"].ToString();
                            txtDiscount.Text = reader["Discount"].ToString();
                            txtRevenue.Text = reader["Revenue"].ToString();
                        }
                    }
                }
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int billID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["ID"].Value);
                OrderDetailsForm detailsForm = new OrderDetailsForm(billID);
                detailsForm.ShowDialog();
            }
        }
    }
}
