using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDA
    {
        public List<Customer> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Customer_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Customer> list = new List<Customer>();

            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                customer.FullName = reader["FullName"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.RoomID = reader["RoomName"] == DBNull.Value ? (int?)null :
                                 (int?)Convert.ToInt32(reader["RoomID"]); // Không cần nếu SP trả RoomName
                customer.RoomName = reader["RoomName"].ToString();
                list.Add(customer);
            }

            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(Customer customer, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Customer_InsertUpdateDelete;

            SqlParameter idPara = new SqlParameter("@CustomerID", SqlDbType.Int);
            idPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(idPara).Value = customer.CustomerID;

            command.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = customer.FullName;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value =
                string.IsNullOrEmpty(customer.Phone) ? (object)DBNull.Value : customer.Phone;
            command.Parameters.Add("@Address", SqlDbType.NVarChar, 200).Value =
                string.IsNullOrEmpty(customer.Address) ? (object)DBNull.Value : customer.Address;
            command.Parameters.Add("@RoomID", SqlDbType.Int).Value =
                customer.RoomID.HasValue ? (object)customer.RoomID.Value : DBNull.Value;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();

            if (result > 0)
                return (int)command.Parameters["@CustomerID"].Value;
            return 0;
        }
    }
}
