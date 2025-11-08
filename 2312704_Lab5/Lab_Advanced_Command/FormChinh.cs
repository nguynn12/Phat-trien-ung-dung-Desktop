using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Advanced_Command
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            var form = new FoodForm();
            form.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var form = new AccountForm();
            form.ShowDialog();
        }
    }
}
