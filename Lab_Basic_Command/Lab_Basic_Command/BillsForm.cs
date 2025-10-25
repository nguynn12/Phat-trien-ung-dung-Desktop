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
    public partial class BillsForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";

        public BillsForm()
        {
            InitializeComponent();
        }

        private void LoadBillForm(DateTime fromDate, DateTime toDate)
        {
            decimal tien = 0, giam = 0, thue = 0;
            decimal tongTien = 0, tongGiamGia = 0, tongThue = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT  b.ID,
                        t.Name as TableName,
                        b.CheckoutDate,
                        b.Discount,
                        b.Tax,
                        b.Status,
                        b.Amount,
                        b.Account
                FROM    Bills b
                JOIN    [Table] t on b.TableID = t.ID
                WHERE   b.CheckoutDate BETWEEN @FromDate AND @ToDate
                ORDER BY b.CheckoutDate ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBills.DataSource = dt;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["Amount"] != DBNull.Value)
                        tien = Convert.ToDecimal(row["Amount"]);

                    if (row["Discount"] != DBNull.Value)
                        giam = Convert.ToDecimal(row["Discount"]);

                    if (row["Tax"] != DBNull.Value)
                        thue = Convert.ToDecimal(row["Tax"]);

                    tongTien += tien;
                    tongGiamGia += tien * (decimal)giam;
                    tongThue += tien * (decimal)thue;
                }

                txtTongTien.Text = tongTien.ToString("N0") + " VNĐ";
                txtTongGiamGia.Text = tongGiamGia.ToString("N0") + " VND";
                txtTongThue.Text = tongThue.ToString("N0") + " VNĐ";
                txtThucThu.Text = (tongTien - tongGiamGia + tongThue).ToString("N0") + " VNĐ";
            }
        }

        private void UpdateBillList()
        {
            DateTime fromDate = dtpTuNgay.Value.Date;
            DateTime toDate = dtpToiNgay.Value.Date;

            if (fromDate > toDate)
            {
                dgvBills.DataSource = null;

                return;
            }

            LoadBillForm(fromDate, toDate);
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(2025, 8, 7);
            dtpToiNgay.Value = DateTime.Now;

            LoadBillForm(dtpTuNgay.Value, dtpToiNgay.Value);
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            UpdateBillList();
        }

        private void dtpToiNgay_ValueChanged(object sender, EventArgs e)
        {
            UpdateBillList();
        }

        private void dgvBills_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string colName = dgvBills.Columns[e.ColumnIndex].Name;

            if (colName == "GiamGia" && e.Value != null)
            {
                double discount = Convert.ToDouble(e.Value);
                e.Value = (discount * 100).ToString("0") + "%";
                e.FormattingApplied = true;
            }

            else if (colName == "Thue" && e.Value != null)
            {
                double tax = Convert.ToDouble(e.Value);
                e.Value = (tax * 100).ToString("0") + "%";
                e.FormattingApplied = true;
            }

            else if (colName == "TrangThai" && e.Value != null)
            {
                int status = Convert.ToInt32(e.Value);
                e.Value = (status == 1) ? "Đã thanh toán" : "Chưa thanh toán";
                e.FormattingApplied = true;
            }

            else if (colName == "TongTien" && e.Value != null)
            {
                decimal amount = Convert.ToDecimal(e.Value);
                e.Value = amount.ToString("N0") + "VNĐ";
                e.FormattingApplied = true;
            }
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // đảm bảo không nhấp vào tiêu đề
            {
                // Lấy ID hóa đơn từ dòng được chọn
                int billID = Convert.ToInt32(dgvBills.Rows[e.RowIndex].Cells["MaHD"].Value);

                // Mở form chi tiết và truyền billID
                BillDetailsForm detailForm = new BillDetailsForm(billID);
                detailForm.ShowDialog();
            }
        }
    }
}
