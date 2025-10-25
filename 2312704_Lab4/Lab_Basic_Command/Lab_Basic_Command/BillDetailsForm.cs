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
    public partial class BillDetailsForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";
        int billID;

        public BillDetailsForm(int billID)
        {
            InitializeComponent();

            this.billID = billID;
        }

        private void LoadBillDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT  f.FoodName,
                               bd.Quantity,
                               f.Price,
                               (bd.Quantity * f.Price) AS Total
                       FROM    BillDetails bd
                       JOIN    Food f on bd.FoodID = f.ID
                       WHERE   bd.ID = @BillID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BillID", billID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBillDetails.DataSource = dt;

                dgvBillDetails.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvBillDetails.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }
        }

        private void BillDetailsForm_Load(object sender, EventArgs e)
        {
            LoadBillDetails();
        }
    }
}
