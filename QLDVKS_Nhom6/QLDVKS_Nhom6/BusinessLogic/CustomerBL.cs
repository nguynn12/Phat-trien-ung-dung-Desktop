using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CustomerBL
    {
        CustomerDA customerDA = new CustomerDA();

        public List<Customer> GetAll()
        {
            return customerDA.GetAll();
        }

        public int Insert(Customer customer)
        {
            return customerDA.Insert_Update_Delete(customer, 0);
        }

        public int Update(Customer customer)
        {
            return customerDA.Insert_Update_Delete(customer, 1);
        }

        public int Delete(Customer customer)
        {
            return customerDA.Insert_Update_Delete(customer, 2);
        }
    }
}
