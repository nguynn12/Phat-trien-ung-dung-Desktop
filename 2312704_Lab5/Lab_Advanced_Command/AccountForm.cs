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
    public partial class AccountForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        public AccountForm()
        {
            InitializeComponent();
        }   

        // 4
        private void LoadAccounts()
        {
            DataTable dt = new DataTable();
            string query = "EXEC GetAllAccounts";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            dgvAccounts.DataSource = dt;
        }

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

            cboRole.DataSource = dt;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "ID";
        }

        // 1
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string query = "EXEC AddAccount @username, @password, @fullname, @email, @tel, @roleID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@username", txtUsermame.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@roleID", (int)cboRole.SelectedValue);

                conn.Open();
                int numRow = cmd.ExecuteNonQuery();

                if (numRow > 0)
                {
                    string newId = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show($"Đã thêm tài khoản mới! ID = {newId}");
                    LoadAccounts();
                }

                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }    
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string query = "EXEC UpdateAccount @id, @username, @roleID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", txtFullName.Text);
                cmd.Parameters.AddWithValue("@username", txtUsermame.Text);
                cmd.Parameters.AddWithValue("@roleID", (int)cboRole.SelectedValue);

                conn.Open();
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show("Đã cập nhật thông tin tài khoản!");
                    LoadAccounts();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string query = "EXEC ResetPassword @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", txtFullName.Text);
                conn.Open();

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show(row > 0 ? "Đã reset mật khẩu!" : "Reset thất bại!");
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            RoleForm frm = new RoleForm();
            frm.ShowDialog();
            LoadAccounts();
        }

        private void dgvAccounts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAccounts.ClearSelection();
                dgvAccounts.Rows[e.RowIndex].Selected = true;
                cmsAccount.Show(Cursor.Position);
            }
        }

        private void tsmXemVaiTro_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow != null)
            {
                string selectedAccountName = dgvAccounts.SelectedRows[0].Cells["AccountName"].Value.ToString();
                RoleForm frm = new RoleForm(selectedAccountName);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xem vai trò!");
            }
        }

        private void tsmXemNhatKy_Click(object sender, EventArgs e)
        {
            ActivityLogForm frm = new ActivityLogForm();
            frm.ShowDialog();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadRoles();
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccounts.Rows[e.RowIndex];

                // Hiển thị thông tin tài khoản
                cboRole.Text = row.Cells["RoleName"].Value?.ToString();
                txtUsermame.Text = row.Cells["AccountName"].Value?.ToString();
                txtPassword.Text = row.Cells["Password"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtTel.Text = row.Cells["Tell"].Value?.ToString();
            }
        }
    }
}
