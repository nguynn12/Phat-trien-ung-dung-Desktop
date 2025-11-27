using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillDetail
    {
        public int BillDetailID { get; set; }

        public int BillID { get; set; }

        public int ServiceID { get; set; }

        public string ServiceName { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get; set; }
    }
}
