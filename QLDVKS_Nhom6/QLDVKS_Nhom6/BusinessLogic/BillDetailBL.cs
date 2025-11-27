using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BillDetailBL
    {
        BillDetailDA billDetailDA = new BillDetailDA();

        public List<BillDetail> GetByBillID(int billId)
        {
            return billDetailDA.GetByBillID(billId);
        }

        public int Insert(int billId, int serviceId, int quantity)
        {
            return billDetailDA.Insert(billId, serviceId, quantity);
        }

        public int Delete(int billDetailID)
        {
            return billDetailDA.Delete(billDetailID);
        }
        public List<ActiveServiceUsage> GetActiveUsage()
        {
            return billDetailDA.GetActiveUsage();
        }
    }
}
