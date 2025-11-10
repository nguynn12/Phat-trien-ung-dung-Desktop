using Lab07_Entity_Framework.Models;
using System;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class RoleEditForm : Form
    {
        public Role Role { get; private set; }

        public RoleEditForm(Role role = null)
        {
            InitializeComponent();
            Role = role ?? new Role();
            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = Role.RoleName;
            txtPath.Text = Role.Path;
            txtNotes.Text = Role.Notes;
            Text = Role.Id == 0 ? "Thêm vai trò mới" : "Sửa vai trò";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên vai trò không được để trống!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Role.RoleName = txtName.Text.Trim();
            Role.Path = txtPath.Text.Trim();
            Role.Notes = txtNotes.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}