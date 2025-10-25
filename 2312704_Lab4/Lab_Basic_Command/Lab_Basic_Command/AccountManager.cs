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
    public partial class AccountManager : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        public AccountManager()
        {
            InitializeComponent();
        }

        private void LoadAccount(string roleName = null, bool? isActive = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT  a.AccountName,
                               a.FullName,
                               a.Email,
                               a.Tell,
                               a.DateCreated,
                               r.RoleName,
                               CASE
                                   WHEN ra.Actived = 1 THEN N'Đang hoạt động'
                                   ELSE N'Ngừng'
                               END AS Stat
                       FROM    Account a
                       LEFT JOIN RoleAccount ra ON a.AccountName = ra.AccountName
                       LEFT JOIN Role r ON ra.RoleID = r.ID
                       WHERE   (@RoleName IS NULL OR r.RoleName = @RoleName) AND
                               (@IsActive IS NULL OR ra.Actived = @IsActive)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoleName", (object)roleName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsActive", (object)isActive ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvAccount.AutoGenerateColumns = false;
                dgvAccount.DataSource = dt;
            }
        }

        private void btnLayThongTin_Click(object sender, EventArgs e)
        {
            LoadAccount(); 
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       INSERT INTO Account (AccountName, FullName, Password, Email, Tell, DateCreated)
                       VALUES (@AccountName, @FullName, @Password, @Email, @Tell, @DateCreated)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", txtTenDangNhap.Text.Trim());
                cmd.Parameters.AddWithValue("@FullName", txtHoVaTen.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtMatKhau.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Tell", txtSoDienThoai.Text.Trim());
                cmd.Parameters.AddWithValue("@DateCreated", dtpNgayTao.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
                LoadAccount();
            }
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       UPDATE  Account
                       SET     FullName = @FullName,
                               Email = @Email,
                               Tell = @Tell
                       WHERE   AccountName = @AccountName";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", txtTenDangNhap.Text.Trim());
                cmd.Parameters.AddWithValue("@FullName", txtHoVaTen.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Tell", txtSoDienThoai.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo");
                LoadAccount();  
            }
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       UPDATE  Account
                       SET     Password = '123456'
                       WHERE   AccountName = @AccountName";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", txtTenDangNhap.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đặt lại mật khẩu thành công!, Mật khẩu mới: 123456", "Thông báo");
            }
        }

        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAccount.ClearSelection();
                dgvAccount.Rows[e.RowIndex].Selected = true;
                contextMenuAccount.Show(Cursor.Position);
            }
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string accountName = dgvAccount.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       UPDATE  RoleAccount
                       SET     Actived = 0
                       WHERE   AccountName = @AccountName";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", accountName);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã vô hiệu hóa các vai trò của tài khoản!", "Thông báo");
                LoadAccount();
            }
        }

        private void xemDanhSáchVaiTròToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string accountName = dgvAccount.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString();

            RoleListForm roleForm = new RoleListForm(accountName);
            roleForm.ShowDialog();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];

                txtTenDangNhap.Text = row.Cells["TenTaiKhoan"].Value?.ToString();
                txtHoVaTen.Text = row.Cells["HoVaTen"].Value?.ToString();
                txtEmail.Text = row.Cells["Mail"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                
                if (DateTime.TryParse(row.Cells["NgayTao"].Value?.ToString(), out DateTime date))
                {
                    dtpNgayTao.Value = date;
                }

                else
                {
                    dtpNgayTao.Value = DateTime.Now;
                }

                string accountName = txtTenDangNhap.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                           SELECT  Password
                           FROM    Account
                           WHERE   AccountName = @AccountName";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    if (result != null)

                        txtMatKhau.Text = result.ToString();

                    else

                        txtMatKhau.Text = "";
                }
            }
        }
    }
}