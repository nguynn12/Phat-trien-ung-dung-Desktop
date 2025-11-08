using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RoleAccountBL
    {
        private readonly RoleAccountDA da = new RoleAccountDA();

        public List<RoleAccount> GetAll() => da.GetAll();

        public int Insert(RoleAccount ra) => da.Insert_Update_Delete(ra, 0);
        
        public int Update(RoleAccount ra) => da.Insert_Update_Delete(ra, 1);
        
        public int Delete(RoleAccount ra) => da.Insert_Update_Delete(ra, 2);

        public List<RoleAccount> Find(string key)
        {
            return GetAll().Where(ra =>
                ra.RoleID.ToString().Contains(key) ||
                (ra.AccountName ?? "").Contains(key)).ToList();
        }
    }
}
