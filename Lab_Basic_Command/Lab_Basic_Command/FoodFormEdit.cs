using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Basic_Command
{
    public partial class FoodFormEdit : Form
    {
        public int? FoodID { get; private set; } = null;

        public string FoodName => txtTenMonAn.Text.Trim();

        public string Unit => txtDonViTinh.Text.Trim();

        public int FoodCategoryID => int.Parse(txtTenNhom.Text);

        public int Price => int.Parse(txtDonGia.Text);

        public string Notes => txtGhiChu.Text.Trim();

        public FoodFormEdit()
        {
            InitializeComponent();
        }

        private bool ValidateInfo()
        {
            return !(string.IsNullOrWhiteSpace(txtTenMonAn.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                string.IsNullOrWhiteSpace(txtTenNhom.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtGhiChu.Text));
        }

        // Load dữ liệu khi cập nhật
        public void LoadDuLieu (DataRow row)
        {
            FoodID = Convert.ToInt32(row["ID"]);
            txtMaMonAn.Text = FoodID.ToString();
            txtTenMonAn.Text = row["FoodName"].ToString();
            txtDonViTinh.Text = row["Unit"].ToString();
            txtTenNhom.Text = row["FoodCategoryID"].ToString();
            txtDonGia.Text = row["Price"].ToString();
            txtGhiChu.Text = row["Notes"].ToString();

            txtMaMonAn.ReadOnly = true;
            btnLuuMonAn.Enabled = true;
            btnThemMonAn.Enabled = false;
        }

        public void SetForAdd()
        {
            FoodID = null;
            txtMaMonAn.Text = "";
            txtTenMonAn.Text = "";
            txtDonViTinh.Text = "";
            txtTenNhom.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";

            txtMaMonAn.ReadOnly = false;
            btnThemMonAn.Enabled = true;
            btnLuuMonAn.Enabled = false;
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if (ValidateInfo())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLuuMonAn_Click(object sender, EventArgs e)
        {
            if (FoodID == null)
            {
                MessageBox.Show("Không có món để cập nhật!");
                return;
            }

            if (!ValidateInfo())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
