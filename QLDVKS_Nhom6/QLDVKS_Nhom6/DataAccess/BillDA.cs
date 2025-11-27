using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillDA
    {
        public Bill GetByRoom(int roomId)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Bill_GetByRoom;

            command.Parameters.Add("@RoomID", SqlDbType.Int).Value = roomId;

            SqlDataReader reader = command.ExecuteReader();
            Bill bill = null;

            if (reader.Read())
            {
                bill = new Bill();
                bill.BillID = Convert.ToInt32(reader["BillID"]);
                bill.RoomID = Convert.ToInt32(reader["RoomID"]);
                bill.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                bill.RoomName = reader["RoomName"].ToString();
                bill.CheckInDate = Convert.ToDateTime(reader["CheckInDate"]);
                bill.CheckOutDate = reader["CheckOutDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["CheckOutDate"]);
                bill.TotalServiceAmount = Convert.ToDecimal(reader["TotalServiceAmount"]);
            }

            sqlConn.Close();
            return bill;
        }

        // Tạo hóa đơn mới khi nhận phòng
        public int Insert(int? roomId, int customerId)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Bill_Insert;

            // SỬA: Xử lý giá trị NULL
            if (roomId.HasValue)
            {
                command.Parameters.Add("@RoomID", SqlDbType.Int).Value = roomId.Value;
            }
            else
            {
                // Nếu roomId là NULL, gửi DBNull.Value
                command.Parameters.Add("@RoomID", SqlDbType.Int).Value = DBNull.Value;
            }
            command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerId;

            SqlParameter billIdPara = new SqlParameter("@BillID", SqlDbType.Int);
            billIdPara.Direction = ParameterDirection.Output;
            command.Parameters.Add(billIdPara);

            command.ExecuteNonQuery();
            sqlConn.Close();

            return (int)billIdPara.Value;
        }

        // Checkout: cập nhật ngày ra + tổng tiền
        public int CheckOut(int billId, decimal totalAmount)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Bill_CheckOut;

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = billId;
            command.Parameters.Add("@TotalServiceAmount", SqlDbType.Money).Value = totalAmount;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result;
        }

        public Bill GetDetailsByID(int billId)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Bill_GetDetailsByID; // SP MỚI

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = billId;

            SqlDataReader reader = command.ExecuteReader();
            Bill bill = null;

            if (reader.Read())
            {
                bill = new Bill();
                bill.BillID = Convert.ToInt32(reader["BillID"]);

                // Xử lý RoomID có thể NULL
                bill.RoomID = reader["RoomID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["RoomID"]);

                bill.RoomName = reader["RoomName"].ToString();
                bill.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                bill.FullName = reader["FullName"].ToString(); // Đọc FullName
                bill.CheckInDate = Convert.ToDateTime(reader["CheckInDate"]);
                bill.CheckOutDate = reader["CheckOutDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["CheckOutDate"]);
                bill.TotalServiceAmount = Convert.ToDecimal(reader["TotalServiceAmount"]);
            }
            sqlConn.Close();
            return bill;
        }

        public int DeleteBill(int billID)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Bill_Delete"; // Tên SP mới

            command.Parameters.Add("@BillID", SqlDbType.Int).Value = billID;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result;
        }
    }
}
