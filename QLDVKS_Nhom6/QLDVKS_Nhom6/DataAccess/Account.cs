using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Account
    {
        public string Username { get; set; }

        public string DisplayName { get; set; }

        public string Password { get; set; }

        public int RoleID { get; set; }

        public string RoleName { get; set; }
    }
}
