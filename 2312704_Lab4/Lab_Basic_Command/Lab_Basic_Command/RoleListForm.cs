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
    public partial class RoleListForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        string accountName;

        public RoleListForm(string accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
        }

        private void LoadRoleList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT  r.RoleName,
                               r.Notes,
                               CASE
                                   WHEN ra.Actived = 1 THEN N'Đang hoạt động'
                                   ELSE N'Không hoạt động'
                               END AS Stat
                       FROM    RoleAccount ra
                       JOIN    Role r ON ra.RoleID = r.ID
                       WHERE   ra.AccountName = @AccountName";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", accountName);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvRoleList.AutoGenerateColumns = true;
                dgvRoleList.DataSource = dt;
            }

            lblAccountName.Text = $"Vai trò của: {accountName}";
        }

        private void RoleListForm_Load(object sender, EventArgs e)
        {
            LoadRoleList();
        }
    }
}
