using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Global
    {
        public static Account CurrentUser { get; set; }
        public static List<RoleAccount> UserRoles { get; set; } = new List<RoleAccount>();

        // Kiểm tra quyền
        public static bool HasRole(int roleID)
        {
            return UserRoles.Any(r => r.RoleID == roleID && r.Actived);
        }

        public static bool IsAdmin() => HasRole(1);      // RoleID = 1

        public static bool IsManager() => HasRole(2);    // RoleID = 2

        public static bool IsAccountant() => HasRole(3); // RoleID = 3

        public static bool IsStaff() => HasRole(4);      // RoleID = 4

        // Xóa dữ liệu khi đăng xuất
        public static void Logout()
        {
            CurrentUser = null;
            UserRoles.Clear();
        }
    }
}
