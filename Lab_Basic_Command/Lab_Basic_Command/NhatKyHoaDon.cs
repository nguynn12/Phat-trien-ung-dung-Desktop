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
    public partial class NhatKyHoaDon : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";
        int tableID;

        public NhatKyHoaDon(int tableID)
        {
            InitializeComponent();
            this.tableID = tableID;
        }

        private void TinhTongKet()
        {
            decimal tongTien = 0;
            decimal tongThue = 0;
            decimal tongGiamGia = 0;
            decimal tongThucThu = 0;
            int tongHoaDon = dgvNhatKy.Rows.Count;

            foreach (DataGridViewRow row in dgvNhatKy.Rows)
            {
                if (row.IsNewRow) continue;

                decimal amount = row.Cells["TongTien"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["TongTien"].Value) : 0;
                decimal discount = row.Cells["GiamGia"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["GiamGia"].Value) : 0;
                decimal tax = row.Cells["Thue"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["Thue"].Value) : 0;

                decimal thucThu = amount - (amount * discount) + (amount * tax);

                tongTien += amount;
                tongGiamGia += (amount * discount);
                tongThue += (amount * tax);
                tongThucThu += thucThu;
            }

            lblTongHoaDon.Text = $"Tổng hóa đơn: {tongHoaDon}";
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
            lblTongGiamGia.Text = $"Tổng giảm giá: {tongGiamGia:N0} VNĐ";
            lblTongThue.Text = $"Tổng thuế: {tongThue:N0} VNĐ";
            lblTongThucThu.Text = $"Tổng thực thu: {tongThucThu:N0} VNĐ";
        }

        private void LoadNhatKyHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                       SELECT  b.ID,
                               t.Name as TableName,
                               b.Account,
                               b.CheckoutDate,
                               b.Amount,
                               b.Discount,
                               b.Tax,
                               (b.Amount - (b.Amount * ISNULL(b.Discount, 0)) + (b.Amount * ISNULL(b.Tax, 0))) AS Total
                       FROM    Bills b
                       INNER JOIN [Table] t ON b.TableID = t.ID
                       WHERE   b.Status = 1 AND
                               b.TableID = @TableID
                       ORDER BY b.CheckoutDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TableID", tableID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvNhatKy.DataSource = dt;

                dgvNhatKy.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dgvNhatKy.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                dgvNhatKy.Columns["ThucThu"].DefaultCellStyle.Format = "N0";

                dgvNhatKy.ClearSelection();
            }

            TinhTongKet();
        }

        private void NhatKyHoaDon_Load(object sender, EventArgs e)
        {
            LoadNhatKyHoaDon();
        }

        private void dgvNhatKy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string colName = dgvNhatKy.Columns[e.ColumnIndex].Name;

            if (colName == "GiamGia" && e.Value != null && e.Value != DBNull.Value)
            {
                double discount = Convert.ToDouble(e.Value);
                e.Value = (discount * 100).ToString("0") + "%";
                e.FormattingApplied = true;
            }
            else if (colName == "Thue" && e.Value != null && e.Value != DBNull.Value)
            {
                double tax = Convert.ToDouble(e.Value);
                e.Value = (tax * 100).ToString("0") + "%";
                e.FormattingApplied = true;
            }
            else if (colName == "TongTien" && e.Value != null && e.Value != DBNull.Value)
            {
                decimal amount = Convert.ToDecimal(e.Value);
                e.Value = amount.ToString("N0") + " VNĐ";
                e.FormattingApplied = true;
            }
            else if (colName == "ThucThu" && e.Value != null && e.Value != DBNull.Value)
            {
                decimal total = Convert.ToDecimal(e.Value);
                e.Value = total.ToString("N0") + " VNĐ";
                e.FormattingApplied = true;
            }
            else if (colName == "NgayLap" && e.Value != null && e.Value != DBNull.Value)
            {
                DateTime date = Convert.ToDateTime(e.Value);
                e.Value = date.ToString("dd/MM/yyyy HH:mm");
                e.FormattingApplied = true;
            }
        }
    }
}
