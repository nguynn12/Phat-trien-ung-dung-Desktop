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
    public partial class RoleForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";
        private string accountName = null;

        public RoleForm(string accName = null)
        {
            InitializeComponent();
            accountName = accName;
        }

        // 4
        private void LoadRoles()
        {
            DataTable dt = new DataTable();
            string query = "EXEC GetAllRoles";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

                dgvRoles.DataSource = dt;

            // Đảm bảo cột checkbox nằm đầu tiên
            if (dgvRoles.Columns["chkSelect"] != null)
            {
                dgvRoles.Columns["chkSelect"].DisplayIndex = 0;
                foreach (DataGridViewRow row in dgvRoles.Rows)
                {
                    row.Cells["chkSelect"].Value = false; // reset lại checkbox
                }
            }
        }

        private void CheckAccountRoles(string accName)
        {
            string query = "EXEC GetRolesByAccountName @accountName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@accountName", accName);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    var roleIds = new HashSet<int>();

                    while (reader.Read())
                    {
                        roleIds.Add(reader.GetInt32(0)); // cột đầu tiên là RoleID
                    }

                    foreach (DataGridViewRow row in dgvRoles.Rows)
                    {
                        int roleId = Convert.ToInt32(row.Cells["ID"].Value);
                        if (roleIds.Contains(roleId))
                            row.Cells["chkSelect"].Value = true;
                    }
                }
            }
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
            if (!string.IsNullOrEmpty(accountName))
                CheckAccountRoles(accountName);
        }

        private void btnAddNewRole_Click(object sender, EventArgs e)
        {
            string query = "EXEC InsertRole @id OUTPUT, @name, @description";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@name", txtRoleName.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);

                conn.Open();
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show("Đã thêm vai trò mới");
                    LoadRoles();
                }

                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            string query = "EXEC UpdateRole @id, @name, @description";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", txtRoleID.Text);
                cmd.Parameters.AddWithValue("@name", txtRoleName.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);

                conn.Open();
                int row = cmd.ExecuteNonQuery();

                MessageBox.Show(row > 0 ? "Cập nhật thành công!" : "Cập nhật thất bại!");
                LoadRoles();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoles.Rows[e.RowIndex];

                txtRoleID.Text = row.Cells["ID"].Value?.ToString();
                txtRoleName.Text = row.Cells["RoleName"].Value?.ToString();
                txtDescription.Text = row.Cells["Notes"].Value?.ToString();
            }
        }
    }
}
