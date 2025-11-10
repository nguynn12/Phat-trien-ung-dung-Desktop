using Lab07_Entity_Framework.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class AccountEditForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();
        public Account Account { get; private set; }

        private bool _isEditMode;

        public AccountEditForm(Account account = null)
        {
            InitializeComponent();
            Account = account ?? new Account();
            _isEditMode = account != null;
            LoadRoles();
            LoadData();
        }

        private void LoadRoles()
        {
            var roles = _db.Roles
                .OrderBy(r => r.RoleName)
                .Select(r => new { r.Id, r.RoleName })
                .ToList();

            clbRoles.DisplayMember = "RoleName";
            clbRoles.ValueMember = "Id";
            clbRoles.DataSource = roles;
        }

        private void LoadData()
        {
            txtAccountName.Text = Account.AccountName;
            txtFullName.Text = Account.FullName;
            txtEmail.Text = Account.Email;
            txtTell.Text = Account.Tell;

            // Nếu là sửa → disable tên đăng nhập
            txtAccountName.Enabled = !_isEditMode;

            // Load roles đã gán
            if (_isEditMode)
            {
                var assignedRoleIds = _db.RoleAccounts
                    .Where(ra => ra.AccountName == Account.AccountName && ra.Actived)
                    .Select(ra => ra.RoleId)
                    .ToList();

                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    var roleId = (int)clbRoles.Items[i].GetType()
                        .GetProperty("Id")
                        .GetValue(clbRoles.Items[i]);

                    clbRoles.SetItemChecked(i, assignedRoleIds.Contains(roleId));
                }
            }

            Text = _isEditMode ? "Sửa tài khoản" : "Thêm tài khoản mới";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtAccountName.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccountName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (!_isEditMode && _db.Accounts.Any(a => a.AccountName == txtAccountName.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccountName.Focus();
                return false;
            }

            if (clbRoles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void UpdateRoleAssignments()
        {
            var selectedRoleIds = clbRoles.CheckedItems
                .Cast<dynamic>()
                .Select(item => (int)item.Id)
                .ToList();

            // Xóa các RoleAccount cũ (nếu có)
            var existing = _db.RoleAccounts
                .Where(ra => ra.AccountName == Account.AccountName)
                .ToList();

            _db.RoleAccounts.RemoveRange(existing);

            // Thêm mới
            foreach (var roleId in selectedRoleIds)
            {
                _db.RoleAccounts.Add(new RoleAccount
                {
                    RoleId = roleId,
                    AccountName = Account.AccountName,
                    Actived = true,
                    Notes = "Gán từ AccountEditForm"
                });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Account.AccountName = txtAccountName.Text.Trim();
            Account.FullName = txtFullName.Text.Trim();
            Account.Email = txtEmail.Text.Trim();
            Account.Tell = txtTell.Text.Trim();

            if (!_isEditMode)
            {
                Account.DateCreated = DateTime.Now;
                Account.Password = "123456"; // Mật khẩu mặc định
            }

            try
            {
                if (!_isEditMode)
                {
                    _db.Accounts.Add(Account);
                }

                // Cập nhật RoleAccount
                UpdateRoleAssignments();

                _db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}