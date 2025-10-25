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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            var form = new BillsForm();

            form.ShowDialog();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            var form = new CategoryForm();

            form.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var form = new AccountManager();

            form.ShowDialog();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            var form = new MainForm();

            form.ShowDialog();
        }
    }
}
