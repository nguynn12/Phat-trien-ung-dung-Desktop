using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Entity_Framework.Models
{
    public class Bill
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int TableId { get; set; }
        
        public int Amount { get; set; }
        
        public double? Discount { get; set; }
        public double? Tax { get; set; }
      
        public bool Status { get; set; }
      
        public DateTime? CheckoutDate { get; set; }
      
        public string Account { get; set; }

        public virtual Table Table { get; set; }
        
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
