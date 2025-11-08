using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
    public partial class frmBills : Form
    {
        private readonly BillsBL bl = new BillsBL();
        private int currentID = 0;

        public frmBills()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var list = bl.GetAll();
            lsvBills.Items.Clear();
            int stt = 1;

            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(item.ID.ToString());
                lvi.SubItems.Add(item.Name ?? "");
                lvi.SubItems.Add(item.TableID.ToString());
                lvi.SubItems.Add(item.Amount.ToString());
                lvi.SubItems.Add(item.Discount.ToString("0.##"));
                lvi.SubItems.Add(item.Tax.ToString("0.##"));
                lvi.SubItems.Add(item.Status ? "Đã thanh toán" : "Chưa thanh toán");
                lvi.SubItems.Add(item.CheckoutDate.HasValue ? item.CheckoutDate.Value.ToString("dd/MM/yyyy") : "");
                lvi.SubItems.Add(item.Account ?? "");
                lvi.Tag = item;
                lsvBills.Items.Add(lvi);
                stt++;
            }

            lblStatistic.Text = $"Tổng: {list.Count} hóa đơn";
            ClearInput();
        }

        private void ClearInput()
        {
            txtID.Clear();
            txtName.Clear();
            txtTableID.Clear();
            txtAmount.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            chkStatus.Checked = false;
            dtpCheckoutDate.Value = DateTime.Today;
            dtpCheckoutDate.Checked = false;
            txtAccount.Clear();
            currentID = 0;
        }

        private void frmBills_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lsvBills_Click(object sender, EventArgs e)
        {
            if (lsvBills.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvBills.SelectedItems[0];
                Bills b = (Bills)lvi.Tag;

                currentID = b.ID;
                txtID.Text = b.ID.ToString();
                txtName.Text = b.Name ?? "";
                txtTableID.Text = b.TableID.ToString();
                txtAmount.Text = b.Amount.ToString();
                txtDiscount.Text = b.Discount.ToString("0.##");
                txtTax.Text = b.Tax.ToString("0.##");
                chkStatus.Checked = b.Status;
                if (b.CheckoutDate.HasValue)
                {
                    dtpCheckoutDate.Value = b.CheckoutDate.Value;
                    dtpCheckoutDate.Checked = true;
                }
                else
                {
                    dtpCheckoutDate.Checked = false;
                }
                txtAccount.Text = b.Account ?? "";
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Bills b = new Bills
                {
                    Name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim(),
                    TableID = int.Parse(txtTableID.Text),
                    Amount = int.Parse(txtAmount.Text),
                    Discount = float.Parse(txtDiscount.Text),
                    Tax = float.Parse(txtTax.Text),
                    Status = chkStatus.Checked,
                    CheckoutDate = dtpCheckoutDate.Checked ? (DateTime?)dtpCheckoutDate.Value : null,
                    Account = string.IsNullOrWhiteSpace(txtAccount.Text) ? null : txtAccount.Text.Trim()
                };

                int result = bl.Insert(b);
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
                MessageBox.Show("Lỗi nhập liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (currentID == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Bills b = new Bills
                {
                    ID = currentID,
                    Name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim(),
                    TableID = int.Parse(txtTableID.Text),
                    Amount = int.Parse(txtAmount.Text),
                    Discount = float.Parse(txtDiscount.Text),
                    Tax = float.Parse(txtTax.Text),
                    Status = chkStatus.Checked,
                    CheckoutDate = dtpCheckoutDate.Checked ? (DateTime?)dtpCheckoutDate.Value : null,
                    Account = string.IsNullOrWhiteSpace(txtAccount.Text) ? null : txtAccount.Text.Trim()
                };

                int result = bl.Update(b);
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
                MessageBox.Show("Vui lòng chọn hóa đơn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Bills b = new Bills
                {
                    ID = currentID,
                    Name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim(),
                    TableID = int.Parse(txtTableID.Text),
                    Amount = int.Parse(txtAmount.Text),
                    Discount = float.Parse(txtDiscount.Text),
                    Tax = float.Parse(txtTax.Text),
                    Status = chkStatus.Checked,
                    CheckoutDate = dtpCheckoutDate.Checked ? (DateTime?)dtpCheckoutDate.Value : null,
                    Account = string.IsNullOrWhiteSpace(txtAccount.Text) ? null : txtAccount.Text.Trim()
                };

                int result = bl.Update(b);
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
