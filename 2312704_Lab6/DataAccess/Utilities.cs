using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;

namespace DataAccess
{
    public class Utilities
    {
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;

        // =====================================
        // STORED PROCEDURE NAMES
        // =====================================

        // Room
        public static string Room_GetAll = "Room_GetAll";
        public static string Room_InsertUpdateDelete = "Room_InsertUpdateDelete";

        // ServiceType
        public static string ServiceType_GetAll = "ServiceType_GetAll";
        public static string ServiceType_InsertUpdateDelete = "ServiceType_InsertUpdateDelete";

        // Service
        public static string Service_GetAll = "Service_GetAll";
        public static string Service_InsertUpdateDelete = "Service_InsertUpdateDelete";

        // Customer
        public static string Customer_GetAll = "Customer_GetAll";
        public static string Customer_InsertUpdateDelete = "Customer_InsertUpdateDelete";

        // Bill
        public static string Bill_GetByRoom = "Bill_GetByRoom";
        public static string Bill_Insert = "Bill_Insert";
        public static string Bill_CheckOut = "Bill_CheckOut";

        // BillDetail
        public static string BillDetail_GetByBillID = "BillDetail_GetByBillID";
        public static string BillDetail_Insert = "BillDetail_Insert";

        // Report
        public static string Report_RevenueByDate = "Report_RevenueByDate";
        public static string Report_RoomsUsingService = "Report_RoomsUsingService";

        // Account & Role
        public static string Account_Login = "Account_Login";
        public static string Account_GetAll = "Account_GetAll";
        public static string Role_GetAll = "Role_GetAll";
    }
}
