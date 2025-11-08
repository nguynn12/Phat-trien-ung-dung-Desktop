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

        public List<Account> GetAll()
        {
            return accountDA.GetAll();
        }

        public int Insert(Account account)
        {
            return accountDA.Insert_Update_Delete(account, 0);
        }

        public int Update(Account account)
        {
            return accountDA.Insert_Update_Delete(account, 1);
        }

        public int Delete(Account account)
        {
            return accountDA.Insert_Update_Delete(account, 2);
        }

        public Account GetByName(string name)
        {
            return GetAll().FirstOrDefault(a => a.AccountName == name);
        }

        public List<Account> Find(string key)
        {
            return GetAll().Where(a => a.AccountName.Contains(key) || a.FullName.Contains(key) || a.Email.Contains(key)).ToList();
        }
    }
}
