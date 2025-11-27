using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Utilities
    {
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;

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
        public static string Bill_GetDetailsByID = "Bill_GetDetailsByID";

        // BillDetail
        public static string BillDetail_GetByBillID = "BillDetail_GetByBillID";
        public static string BillDetail_Insert = "BillDetail_Insert";
        public static string BillDetail_Delete = "BillDetail_Delete";

        // Report
        public static string Report_GetRevenueByRange = "Report_GetRevenueByRange";
        public static string Report_RoomsUsingService = "Report_RoomsUsingService";
        public static string Report_GetActiveServiceUsage = "Report_GetActiveServiceUsage";

        // Account & Role
        public static string Account_Login = "Account_Login";
        public static string Account_GetAll = "Account_GetAll";
        public static string Account_InsertUpdateDelete = "Account_InsertUpdateDelete";
        public static string Account_ResetPassword = "Account_ResetPassword";
        public static string Role_GetAll = "Role_GetAll";
    }
}
