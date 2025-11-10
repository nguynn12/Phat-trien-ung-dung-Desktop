using Lab07_Entity_Framework.Models;
using System;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class TableEditForm : Form
    {
        public Table Table { get; private set; }

        public TableEditForm(Table table = null)
        {
            InitializeComponent();
            Table = table ?? new Table();
            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = Table.Name;
            cbbStatus.SelectedIndex = Table.Status; // 0: Trống, 1: Đang dùng
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bàn!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            Table.Name = txtName.Text.Trim();
            Table.Status = cbbStatus.SelectedIndex;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}