using Lab07_Entity_Framework.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    public partial class TableForm : Form
    {
        private readonly RestaurantContext _db = new RestaurantContext();

        public TableForm()
        {
            InitializeComponent();
            LoadTables();
        }

        private void LoadTables()
        {
            var tables = _db.Tables
                .OrderBy(t => t.Name)
                .Select(t => new
                {
                    t.Id,
                    t.Name,
                    StatusText = t.Status == 1 ? "Đang dùng" : "Trống"
                })
                .ToList();

            dgvTables.DataSource = tables;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new TableEditForm())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _db.Tables.Add(dlg.Table);
                    _db.SaveChanges();
                    LoadTables();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count == 0) return;

            var tableId = (int)dgvTables.SelectedRows[0].Cells["colId"].Value;
            var table = _db.Tables.Find(tableId);

            if (table == null) return;

            using (var dlg = new TableEditForm(table))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    table.Name = dlg.Table.Name;
                    table.Status = dlg.Table.Status;
                    _db.SaveChanges();
                    LoadTables();
                }
            }
        }

        private void mnuViewBills_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count == 0) return;

            var tableId = (int)dgvTables.SelectedRows[0].Cells["colId"].Value;
            var tableName = dgvTables.SelectedRows[0].Cells["colName"].Value.ToString();

            using (var dlg = new BillByDateForm(tableId, tableName))
            {
                dlg.ShowDialog(this);
            }
        }

        private void mnuViewLog_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count == 0) return;

            var tableId = (int)dgvTables.SelectedRows[0].Cells["colId"].Value;
            var tableName = dgvTables.SelectedRows[0].Cells["colName"].Value.ToString();

            using (var dlg = new SalesLogForm(tableId, tableName))
            {
                dlg.ShowDialog(this);
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count == 0) return;

            var tableId = (int)dgvTables.SelectedRows[0].Cells["colId"].Value;
            var table = _db.Tables.Find(tableId);

            if (table == null) return;

            if (MessageBox.Show($"Xóa bàn '{table.Name}'?\n" +
                                "Tất cả hóa đơn liên quan sẽ bị xóa!", "Xác nhận xóa",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _db.Tables.Remove(table);
                _db.SaveChanges();
                LoadTables();
            }
        }

        private void dgvTables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var tableId = (int)dgvTables.Rows[e.RowIndex].Cells["colId"].Value;
            var tableName = dgvTables.Rows[e.RowIndex].Cells["colName"].Value.ToString();

            using (var form = new BillsForm())
            {
                form.Text = $"Hóa đơn - Bàn: {tableName}";
                form.Tag = tableId;
                form.ShowDialog(this);
            }
        }
    }
}