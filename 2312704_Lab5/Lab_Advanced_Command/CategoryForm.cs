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
    public partial class CategoryForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string query = "EXEC InsertCategory @id OUTPUT, @name, @type";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@name", txtCatName.Text);
                    cmd.Parameters.AddWithValue("@type", (int)nudType.Value);

                    conn.Open();
                    int numRow = cmd.ExecuteNonQuery();

                    if (numRow > 0)
                    {
                        string catId = cmd.Parameters["@id"].Value.ToString();
                        MessageBox.Show($"Đã thêm nhóm món ăn mới! ID = {catId}", "Thông báo");
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Thêm nhóm món ăn thất bại!");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
