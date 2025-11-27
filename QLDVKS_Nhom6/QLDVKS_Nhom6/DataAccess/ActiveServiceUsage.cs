using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ActiveServiceUsage
    {
        public int BillID { get; set; }
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string TypeName { get; set; }       // Tên loại DV
        public string ServiceName { get; set; }    // Tên dịch vụ
        public int Quantity { get; set; }
        public decimal Price { get; set; }          // Đơn giá
        public DateTime CheckInDate { get; set; }  // Ngày sử dụng
        public decimal Amount { get; set; }         // Thành tiền
    }
}
