using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BillsBL
    {
        private readonly BillsDA da = new BillsDA();

        public List<Bills> GetAll() => da.GetAll();

        public int Insert(Bills b) => da.Insert_Update_Delete(b, 0);

        public int Update(Bills b) => da.Insert_Update_Delete(b, 1);

        public int Delete(Bills b) => da.Insert_Update_Delete(b, 2);

        public List<Bills> Find(string key)
        {
            return GetAll().Where(b =>
                b.ID.ToString().Contains(key) ||
                (b.Name ?? "").Contains(key) ||
                b.TableID.ToString().Contains(key) ||
                b.Amount.ToString().Contains(key)).ToList();
        }
    }
}
