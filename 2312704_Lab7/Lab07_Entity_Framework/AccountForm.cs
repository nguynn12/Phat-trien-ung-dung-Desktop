using Lab07_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class AccountForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();

        public AccountForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadRolesToComboBox();
        }

        private void SetupDataGridView()
        {
            dgvAccounts.AutoGenerateColumns = false;
            dgvAccounts.Columns.Clear();

            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AccountName",
                HeaderText = "Tên đăng nhập",
                Width = 120
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Họ tên",
                Width = 150
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 180
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tell",
                HeaderText = "Điện thoại",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DateCreated",
                HeaderText = "Ngày tạo",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
        }

        private void LoadRolesToComboBox()
        {
            var roles = _db.Roles.OrderBy(r => r.RoleName).ToList();
            roles.Insert(0, new Role { Id = 0, RoleName = "[Tất cả vai trò]" });

            cbbRole.DisplayMember = "RoleName";
            cbbRole.ValueMember = "Id";
            cbbRole.DataSource = roles;
            cbbRole.SelectedIndex = 0;
        }

        private void LoadAccounts()
        {
            var query = _db.Accounts.AsQueryable();

            // Lọc theo Role
            if (cbbRole.SelectedValue is int roleId && roleId > 0)
            {
                query = query.Where(a => a.RoleAccounts.Any(ra => ra.RoleId == roleId && ra.Actived));
            }

            // Lọc theo tên
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var keyword = txtSearch.Text.Trim().ToLower();
                query = query.Where(a => a.FullName.ToLower().Contains(keyword) ||
                                        a.AccountName.ToLower().Contains(keyword));
            }

            var accounts = query
                .OrderBy(a => a.FullName)
                .Select(a => new
                {
                    a.AccountName,
                    a.FullName,
                    a.Email,
                    a.Tell,
                    a.DateCreated
                })
                .ToList();

            dgvAccounts.DataSource = accounts;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadAccounts();

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadAccounts();
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new AccountEditForm())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _db.Accounts.Add(dlg.Account);
                    _db.SaveChanges();
                    LoadAccounts();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0) return;

            var accountName = dgvAccounts.SelectedRows[0].Cells[0].Value.ToString();
            var account = _db.Accounts.Find(accountName);

            using (var dlg = new AccountEditForm(account))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    var dbAccount = _db.Accounts.Find(account.AccountName);
                    dbAccount.FullName = dlg.Account.FullName;
                    dbAccount.Email = dlg.Account.Email;
                    dbAccount.Tell = dlg.Account.Tell;
                    _db.SaveChanges();
                    LoadAccounts();
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0) return;

            var accountName = dgvAccounts.SelectedRows[0].Cells[0].Value.ToString();
            var account = _db.Accounts.Find(accountName);

            if (MessageBox.Show($"Bạn có chắc muốn reset mật khẩu của tài khoản '{accountName}'?\n" +
                               "Tài khoản sẽ không thể đăng nhập cho đến khi đổi mật khẩu mới.",
                               "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                account.Password = null;
                _db.SaveChanges();
                MessageBox.Show("Đã reset mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvAccounts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgvAccounts.SelectedRows.Count > 0)
            {
                contextMenuStrip.Show(dgvAccounts, e.Location);
            }
        }

        private void mnuDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0) return;

            var accountName = dgvAccounts.SelectedRows[0].Cells[0].Value.ToString();
            var account = _db.Accounts.Find(accountName);

            if (MessageBox.Show($"Xóa tài khoản '{accountName}'?\n" +
                               "Mật khẩu sẽ bị xóa → tài khoản không thể đăng nhập.",
                               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                account.Password = null;
                _db.SaveChanges();
                LoadAccounts();
            }
        }

        private void mnuViewRoles_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0) return;

            var accountName = dgvAccounts.SelectedRows[0].Cells[0].Value.ToString();
            var roles = _db.RoleAccounts
                .Where(ra => ra.AccountName == accountName && ra.Actived)
                .Select(ra => ra.Role.RoleName)
                .ToList();

            var message = roles.Count > 0
                ? string.Join("\n", roles)
                : "Không có vai trò nào được gán.";

            MessageBox.Show($"Vai trò của '{accountName}':\n\n{message}",
                "Danh sách vai trò", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0) return;

            var accountName = dgvAccounts.SelectedRows[0].Cells[0].Value.ToString();
            using (var dlg = new ChangePasswordForm(accountName))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    var account = _db.Accounts.Find(accountName);
                    account.Password = dlg.NewPassword;
                    _db.SaveChanges();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                }
            }
        }
    }
}
