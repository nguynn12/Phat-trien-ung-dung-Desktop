using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurantManagementProject
{
    public partial class frmBillDetails : Form
    {
        private readonly BillDetailsBL bl = new BillDetailsBL();
        private int currentID = 0;

        public frmBillDetails()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            var list = bl.GetAll();
            lsvBillDetails.Items.Clear();
            int stt = 1;

            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(item.ID.ToString());
                lvi.SubItems.Add(item.InvoiceID.ToString());
                lvi.SubItems.Add(item.FoodID.ToString());
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.Tag = item;
                lsvBillDetails.Items.Add(lvi);
                stt++;
            }

            lblStatistic.Text = $"Tổng: {list.Count} chi tiết";
            ClearInput();
        }

        private void ClearInput()
        {
            txtID.Clear();
            txtInvoiceID.Clear();
            txtFoodID.Clear();
            txtQuantity.Clear();
            currentID = 0;
        }

        private void frmBillDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void lsvBillDetails_Click(object sender, EventArgs e)
        {
            if (lsvBillDetails.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvBillDetails.SelectedItems[0];
                BillDetails bd = (BillDetails)lvi.Tag;

                currentID = bd.ID;
                txtID.Text = bd.ID.ToString();
                txtInvoiceID.Text = bd.InvoiceID.ToString();
                txtFoodID.Text = bd.FoodID.ToString();
                txtQuantity.Text = bd.Quantity.ToString();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BillDetails bd = new BillDetails
                {
                    InvoiceID = int.Parse(txtInvoiceID.Text),
                    FoodID = int.Parse(txtFoodID.Text),
                    Quantity = int.Parse(txtQuantity.Text)
                };

                int result = bl.Insert(bd);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (currentID == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                BillDetails bd = new BillDetails
                {
                    ID = currentID,
                    InvoiceID = int.Parse(txtInvoiceID.Text),
                    FoodID = int.Parse(txtFoodID.Text),
                    Quantity = int.Parse(txtQuantity.Text)
                };

                int result = bl.Update(bd);
                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (currentID == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BillDetails bd = new BillDetails { ID = currentID };
                    int result = bl.Delete(bd);
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
