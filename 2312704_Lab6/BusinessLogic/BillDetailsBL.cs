using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BillDetailsBL
    {
        private readonly BillDetailsDA da = new BillDetailsDA();

        public List<BillDetails> GetAll() => da.GetAll();

        public int Insert(BillDetails bd) => da.Insert_Update_Delete(bd, 0);

        public int Update(BillDetails bd) => da.Insert_Update_Delete(bd, 1);

        public int Delete(BillDetails bd) => da.Insert_Update_Delete(bd, 2);

        public List<BillDetails> Find(string key)
        {
            return GetAll().Where(b =>
                b.ID.ToString().Contains(key) ||
                b.InvoiceID.ToString().Contains(key) ||
                b.FoodID.ToString().Contains(key) ||
                b.Quantity.ToString().Contains(key)).ToList();
        }
    }
}
