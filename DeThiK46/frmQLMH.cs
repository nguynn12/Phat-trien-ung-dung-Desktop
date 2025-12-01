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

namespace DeThiK46
{
    public partial class frmQLMH : Form
    {
        string connectionString = "server=.; database = QLDKHP; Integrated Security = true;";
        string chuoiMa = "";

        public frmQLMH()
        {
            InitializeComponent();
        }

        private void LoadMH(string chuoiMa)
        {
            string query =
                $@" SELECT	MaMH, TenMH, 
                    		Phu.TenCTDT,
                    		SoTC
                     FROM	MonHoc mh
                    		JOIN 
                    		(SELECT TenCTDT, MaCTDT
                    		 FROM	ChuongTrinhDT) Phu 
                    		 ON mh.MaCTĐT = Phu.MaCTDT
                    WHERE   Phu.MaCTDT IN ({chuoiMa})";

            using (SqlConnection conn =  new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMonHoc.DataSource = dt;
            }
        }

        private void ThongKeSoLuong()
        {
            string query = "EXEC ThongKeSoLuong @mamh, @kq OUTPUT";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                DataGridViewRow dongDuocChon = dgvMonHoc.SelectedRows[0];
                DataRowView rowView = dongDuocChon.DataBoundItem as DataRowView;

                string maMH = rowView["MaMH"].ToString().Trim();

                cmd.Parameters.Add("@mamh", SqlDbType.NChar, 10).Value = maMH;
                cmd.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                int tongSV = Convert.ToInt32(cmd.Parameters["@kq"].Value);

                MessageBox.Show($"Có tất cả {tongSV} đã đăng ký môn học này", "Thông báo",
                    MessageBoxButtons.OK);
            }
        }

        private void frmQLMH_Load(object sender, EventArgs e)
        {
            rdTatCa.Checked = true;
            chuoiMa = "1, 2, 3";
            LoadMH(chuoiMa);
        }

        private void rd2015_CheckedChanged(object sender, EventArgs e)
        {
            chuoiMa = "1";
            LoadMH(chuoiMa);
        }

        private void rd2017_CheckedChanged(object sender, EventArgs e)
        {
            chuoiMa = "2";
            LoadMH(chuoiMa);
        }

        private void rd2020_CheckedChanged(object sender, EventArgs e)
        {
            chuoiMa = "3";
            LoadMH(chuoiMa);
        }

        private void rdTatCa_CheckedChanged(object sender, EventArgs e)
        {
            chuoiMa = "1, 2, 3";
            LoadMH(chuoiMa);
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            chuoiMa = "1, 2, 3";
            LoadMH(chuoiMa);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.ShowDialog(this);
        }

        private void dgvMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dongDuocChon = dgvMonHoc.SelectedRows[0];
                DataRowView rowView = dongDuocChon.DataBoundItem as DataRowView;

                string maMH = rowView["MaMH"].ToString();

                Form1 form = new Form1();
                form.MaMH = maMH;

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    chuoiMa = "1, 2, 3";

                    LoadMH(chuoiMa);
                }

                // DataRowView rowView = dgvMonHoc.CurrentRow.DataBoundItem as DataRowView;
            }
        }

        private void tsmThongKe_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.SelectedRows.Count > 0)
            {
                ThongKeSoLuong();
            }
        }
    }
}
