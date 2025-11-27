using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ServiceBL
    {
        ServiceDA serviceDA = new ServiceDA();

        public List<Service> GetAll()
        {
            return serviceDA.GetAll();
        }

        public int Insert(Service service)
        {
            return serviceDA.Insert_Update_Delete(service, 0);
        }

        public int Update(Service service)
        {
            return serviceDA.Insert_Update_Delete(service, 1);
        }

        public int Delete(Service service)
        {
            return serviceDA.Insert_Update_Delete(service, 2);
        }
    }
}
