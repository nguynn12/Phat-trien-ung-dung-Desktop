using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RestaurantTableBL
    {
        private readonly RestaurantTableDA da = new RestaurantTableDA();

        public List<RestaurantTable> GetAll() => da.GetAll();

        public int Insert(RestaurantTable t) => da.Insert_Update_Delete(t, 0);
        
        public int Update(RestaurantTable t) => da.Insert_Update_Delete(t, 1);
        
        public int Delete(RestaurantTable t) => da.Insert_Update_Delete(t, 2);

        public List<RestaurantTable> Find(string key)
        {
            return GetAll().Where(t =>
                t.ID.ToString().Contains(key) ||
                (t.Name ?? "").Contains(key) ||
                t.Status.ToString().Contains(key) ||
                (t.Capacity?.ToString() ?? "").Contains(key)).ToList();
        }
    }
}
