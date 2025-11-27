using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillDetailDA
    {
        public List<BillDetail> GetByBillID(int billId)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.BillDetail_GetByBillID;

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = billId;

            SqlDataReader reader = command.ExecuteReader();
            List<BillDetail> list = new List<BillDetail>();

            while (reader.Read())
            {
                BillDetail detail = new BillDetail();
                detail.BillDetailID = Convert.ToInt32(reader["BillDetailID"]);
                detail.BillID = Convert.ToInt32(reader["BillID"]);
                detail.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                detail.ServiceName = reader["ServiceName"].ToString();
                detail.Quantity = Convert.ToInt32(reader["Quantity"]);
                detail.Amount = Convert.ToDecimal(reader["Amount"]);
                list.Add(detail);
            }

            sqlConn.Close();
            return list;
        }

        // Thêm dịch vụ vào hóa đơn
        public int Insert(int billId, int serviceId, int quantity)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.BillDetail_Insert; // SP đã sửa

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = billId;
            command.Parameters.Add("@ServiceID", SqlDbType.Int).Value = serviceId;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result;
        }

        public int Delete(int billDetailID)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.BillDetail_Delete; // SP MỚI

            command.Parameters.Add("@BillDetailID", SqlDbType.Int).Value = billDetailID;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result;
        }

        public List<ActiveServiceUsage> GetActiveUsage()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Report_GetActiveServiceUsage; // Gọi SP mới

            SqlDataReader reader = command.ExecuteReader();
            List<ActiveServiceUsage> list = new List<ActiveServiceUsage>();

            while (reader.Read())
            {
                ActiveServiceUsage item = new ActiveServiceUsage();
                item.BillID = Convert.ToInt32(reader["BillID"]);
                item.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                item.FullName = reader["FullName"].ToString();
                item.TypeName = reader["TypeName"].ToString();
                item.ServiceName = reader["ServiceName"].ToString();
                item.Quantity = Convert.ToInt32(reader["Quantity"]);
                item.Price = Convert.ToDecimal(reader["Price"]);
                item.CheckInDate = Convert.ToDateTime(reader["CheckInDate"]);
                item.Amount = Convert.ToDecimal(reader["Amount"]);
                list.Add(item);
            }

            sqlConn.Close();
            return list;
        }
    }
}
