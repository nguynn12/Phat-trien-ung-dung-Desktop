using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Service
    {
        public int ServiceID { get; set; }

        public string ServiceName { get; set; }

        public decimal Price { get; set; }

        public int ServiceTypeID { get; set; }

        public string TypeName { get; set; }
    }
}
