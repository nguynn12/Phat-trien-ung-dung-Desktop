using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RoleBL
    {
        private readonly RoleDA da = new RoleDA();

        public List<Role> GetAll() => da.GetAll();

        public int Insert(Role r) => da.Insert_Update_Delete(r, 0);

        public int Update(Role r) => da.Insert_Update_Delete(r, 1);

        public int Delete(Role r) => da.Insert_Update_Delete(r, 2);

        public List<Role> Find(string key)
        {
            return GetAll().Where(r =>
                r.ID.ToString().Contains(key) ||
                (r.RoleName ?? "").Contains(key) ||
                (r.Path ?? "").Contains(key)).ToList();
        }
    }
}
