using Lab07_Entity_Framework.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class RoleForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();

        public RoleForm()
        {
            InitializeComponent();
            SetupListViews();
        }

        private void SetupListViews()
        {
            // lvwRoles
            colId = new ColumnHeader { Text = "ID", Width = 60 };
            colName = new ColumnHeader { Text = "Tên vai trò", Width = 180 };
            colPath = new ColumnHeader { Text = "Đường dẫn", Width = 150 };
            lvwRoles.Columns.AddRange(new[] { colId, colName, colPath });
            lvwRoles.FullRowSelect = true;
            lvwRoles.GridLines = true;

            // lvwUsers
            colUserName = new ColumnHeader { Text = "Tên người dùng", Width = 200 };
            lvwUsers.Columns.Add(colUserName);
            lvwUsers.FullRowSelect = true;
            lvwUsers.GridLines = true;
        }

        private void LoadRoles()
        {
            var roles = _db.Roles.OrderBy(r => r.RoleName).ToList();
            lvwRoles.Items.Clear();
            foreach (var r in roles)
            {
                var item = new ListViewItem(r.Id.ToString()) { Tag = r };
                item.SubItems.Add(r.RoleName);
                item.SubItems.Add(r.Path ?? "");
                lvwRoles.Items.Add(item);
            }
        }

        private void LoadUsersForRole(int roleId)
        {
            var users = _db.RoleAccounts
                .Where(ra => ra.RoleId == roleId && ra.Actived)
                .Select(ra => ra.Account.FullName)
                .OrderBy(n => n)
                .ToList();

            lvwUsers.Items.Clear();
            foreach (var name in users)
                lvwUsers.Items.Add(name);
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void lvwRoles_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnEdit.Enabled = lvwRoles.SelectedItems.Count > 0;

            if (lvwRoles.SelectedItems.Count == 0)
            {
                lvwUsers.Items.Clear();
                return;
            }

            var roleId = int.Parse(lvwRoles.SelectedItems[0].Text);
            LoadUsersForRole(roleId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new RoleEditForm())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _db.Roles.Add(dlg.Role);
                    _db.SaveChanges();
                    LoadRoles();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwRoles.SelectedItems.Count == 0) return;

            var role = (Role)lvwRoles.SelectedItems[0].Tag;
            using (var dlg = new RoleEditForm(role))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    var dbRole = _db.Roles.Find(role.Id);
                    dbRole.RoleName = dlg.Role.RoleName;
                    dbRole.Path = dlg.Role.Path;
                    dbRole.Notes = dlg.Role.Notes;
                    _db.SaveChanges();
                    LoadRoles();
                }
            }
        }
    }
}