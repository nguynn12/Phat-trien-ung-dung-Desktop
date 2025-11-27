using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BillBL
    {
        BillDA billDA = new BillDA();

        public Bill GetByRoom(int roomId)
        {
            return billDA.GetByRoom(roomId);
        }

        public int Insert(int? roomId, int customerId)
        {
            return billDA.Insert(roomId, customerId);
        }

        public int CheckOut(int billId, decimal totalAmount)
        {
            return billDA.CheckOut(billId, totalAmount);
        }
        public Bill GetDetailsByID(int billId)
        {
            return billDA.GetDetailsByID(billId);
        }

        public int DeleteBill(int billID)
        {
            return billDA.DeleteBill(billID);
        }
    }
}
