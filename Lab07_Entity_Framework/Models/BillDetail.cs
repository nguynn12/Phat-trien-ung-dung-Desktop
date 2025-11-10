using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Entity_Framework.Models
{
    public class BillDetail
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int FoodId { get; set; }
        public int Quantity { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Food Food { get; set; }
    }
}
