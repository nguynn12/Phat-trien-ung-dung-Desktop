using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AccountBL
    {
        AccountDA accountDA = new AccountDA();

        public Account Login(string username, string password)
        {
            return accountDA.Login(username, password);
        }

        public List<Account> GetAll()
        {
            return accountDA.GetAll();
        }

        public int Insert(Account acc)
        {
            // Logic kiểm tra (ví dụ: acc.Username đã tồn tại?) 
            // có thể thêm ở đây. Tạm thời gọi thẳng DA.
            return accountDA.InsertUpdateDelete(acc, 0); // 0 = Insert
        }

        public int Update(Account acc)
        {
            return accountDA.InsertUpdateDelete(acc, 1); // 1 = Update
        }

        public int Delete(Account acc)
        {
            return accountDA.InsertUpdateDelete(acc, 2); // 2 = Delete
        }

        public int ResetPassword(string username, string newPassword)
        {
            return accountDA.ResetPassword(username, newPassword);
        }
    }
}
