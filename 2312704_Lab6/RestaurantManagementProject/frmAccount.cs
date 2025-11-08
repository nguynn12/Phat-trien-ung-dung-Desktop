using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace RestaurantManagementProject
{
    public partial class frmAccount : Form
    {
        List<Account> listAccount = new List<Account>();
        Account currentAccount = new Account();

        public frmAccount()
        {
            InitializeComponent();
        }

        private void LoadAccountDataToListView()
        {
            AccountBL accountBL = new AccountBL();
            listAccount = accountBL.GetAll();

            int count = 1;
            lsvAccount.Items.Clear();

            foreach (var acc in listAccount)
            {
                ListViewItem item = lsvAccount.Items.Add(count.ToString());

                item.SubItems.Add(acc.AccountName);
                item.SubItems.Add(acc.FullName);
                item.SubItems.Add(acc.Email);
                item.SubItems.Add(acc.Tell);
                item.SubItems.Add(acc.DateCreated.ToString());

                count++;
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadAccountDataToListView();
        }

        private void lsvAccount_Click(object sender, EventArgs e)
        {
            if (lsvAccount.SelectedItems.Count > 0)
            {
                currentAccount = listAccount[lsvAccount.SelectedIndices[0]];

                txtAccountName.Text = currentAccount.AccountName;
                txtPassword.Text = currentAccount.Password;
                txtFullName.Text = currentAccount.FullName;
                txtEmail.Text = currentAccount.Email;
                txtTell.Text = currentAccount.Tell;
                dtpDateCreated.Value = currentAccount.DateCreated;
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");

                return;
            }

            Account acc = new Account
            {
                AccountName = txtAccountName.Text,
                Password = txtPassword.Text,
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                Tell = txtTell.Text,
                DateCreated = dtpDateCreated.Value
            };

            AccountBL bl = new AccountBL();

            if (bl.Insert(acc) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                LoadAccountDataToListView();
            }

            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
