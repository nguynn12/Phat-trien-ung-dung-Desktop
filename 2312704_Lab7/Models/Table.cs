using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Entity_Framework.Models
{
    public class Table
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int Status { get; set; } // 0: trống, 1: có người, 2: đang dọn
        
        public int? Capacity { get; set; }
    }
}
