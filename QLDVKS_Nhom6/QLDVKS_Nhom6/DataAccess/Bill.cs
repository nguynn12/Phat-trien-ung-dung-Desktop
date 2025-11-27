using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Bill
    {
        public int BillID { get; set; }

        public int RoomID { get; set; }

        public int CustomerID { get; set; }

        public string FullName { get; set; }

        public string RoomName { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public decimal TotalServiceAmount { get; set; }
    }
}
