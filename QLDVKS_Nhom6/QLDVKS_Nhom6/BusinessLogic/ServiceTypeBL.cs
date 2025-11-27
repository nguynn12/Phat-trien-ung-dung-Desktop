using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ServiceTypeBL
    {
        ServiceTypeDA serviceTypeDA = new ServiceTypeDA();

        public List<ServiceType> GetAll()
        {
            return serviceTypeDA.GetAll();
        }

        public int Insert(ServiceType type)
        {
            return serviceTypeDA.Insert_Update_Delete(type, 0);
        }

        public int Update(ServiceType type)
        {
            return serviceTypeDA.Insert_Update_Delete(type, 1);
        }

        public int Delete(ServiceType type)
        {
            return serviceTypeDA.Insert_Update_Delete(type, 2);
        }
    }
}
