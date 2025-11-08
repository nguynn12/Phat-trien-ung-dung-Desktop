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
    public partial class OrderDetailsForm : Form
    {
        string connectionString = "server =.; database = Restaurant Management; Integrated Security = true";
        int billID;

        public OrderDetailsForm(int id)
        {
            InitializeComponent();
            billID = id;
        }

         
    }
}
