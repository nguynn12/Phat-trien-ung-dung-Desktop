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
        RoleDA roleDA = new RoleDA();

        public List<Role> GetAll()
        {
            return roleDA.GetAll();
        }
    }
}
