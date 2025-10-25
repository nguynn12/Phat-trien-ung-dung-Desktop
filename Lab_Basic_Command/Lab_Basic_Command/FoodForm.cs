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
    public partial class FoodForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        public FoodForm()
        {
            InitializeComponent();
        }

        public void LoadFood(int categoryID)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT Name FROM Category where ID = " + categoryID;

            sqlConnection.Open();

            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            dgvFood.DataSource = dt;

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

            dgvFood.ClearSelection();
        }

        private void ThemMonAn(FoodFormEdit form, SqlConnection sqlConnection)
        {
            string query = "INSERT INTO Food (FoodName, Unit, FoodCategoryID, Price, Notes) " +
                           "VALUES (@FoodName, @Unit, @FoodCategoryID, @Price, @Notes)";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@FoodName", form.FoodName);
                cmd.Parameters.AddWithValue("@Unit", form.Unit);
                cmd.Parameters.AddWithValue("@FoodCategoryID", form.FoodCategoryID);
                cmd.Parameters.AddWithValue("@Price", form.Price);
                cmd.Parameters.AddWithValue("@Notes", form.Notes);

                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void CapNhatMonAn(FoodFormEdit form, SqlConnection sqlConnection)
        {
            string query = "UPDATE Food "
                         + "SET FoodName = @FoodName, "
                         + "    Unit = @Unit, "
                         + "    FoodCategoryID = @FoodCategoryID, "
                         + "    Price = @Price, "
                         + "    Notes = @Notes "
                         + "WHERE ID = @ID";
            
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@FoodName", form.FoodName);
                cmd.Parameters.AddWithValue("@Unit", form.Unit);    
                cmd.Parameters.AddWithValue("@FoodCategoryID", form.FoodCategoryID);
                cmd.Parameters.AddWithValue("@Price", form.Price);
                cmd.Parameters.AddWithValue("@Notes", form.Notes);
                cmd.Parameters.AddWithValue("@ID", form.FoodID.Value);

                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }

        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            FoodFormEdit form = new FoodFormEdit();
 
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            if (dgvFood.CurrentRow != null && dgvFood.CurrentRow.Index >= 0 && dgvFood.SelectedRows.Count > 0)
            {
                DataRowView drw = dgvFood.CurrentRow.DataBoundItem as DataRowView;
                if (drw != null)
                {
                    form.LoadDuLieu(drw.Row);
                }
            }

            else
            {
                form.SetForAdd();
            }

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                if (form.FoodID == null)
                
                    ThemMonAn(form, sqlConnection);
                
                else

                    CapNhatMonAn(form, sqlConnection);

                if (dgvFood.DataSource is DataTable dt)
                {
                    dt.Clear();

                    sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + form.FoodCategoryID;

                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    da.Fill(dt);
                    da.Dispose();
                }

                dgvFood.ClearSelection();
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra coi có dòng nào được chọn không
            if (dgvFood.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!");

                return;
            }

            // Lấy ID của món ăn được chọn
            DataRowView drv = dgvFood.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null)
            {
                MessageBox.Show("Không lấy được thông tin món ăn");

                return;
            }

            int foodId = Convert.ToInt32(drv["ID"]);

            DialogResult confirm = MessageBox.Show(
                "Bạn chắc chắn muốn xóa món ăn này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) 
                return;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = sqlConnection.CreateCommand();

                // Xóa BillDetails trước, rồi xóa món ăn

                cmd.CommandText = @"
                    DELETE bd
                    FROM BillDetails bd
                    JOIN Food f ON bd.FoodID = f.ID
                    WHERE f.ID = @FoodID;
                    
                    DELETE FROM Food WHERE ID = @FoodID";

                cmd.Parameters.AddWithValue("@FoodID", foodId);

                sqlConnection.Open();

                int numOfRowsEffected = cmd.ExecuteNonQuery();

                sqlConnection.Close();

                if (numOfRowsEffected >= 1)
                {
                    drv.Delete();
                    MessageBox.Show("Xóa món ăn thành công!");
                }

                else

                    MessageBox.Show("Không thể xóa món ăn");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvFood.ClearSelection();
        }
    }
}
