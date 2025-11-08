using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillsDA
    {
        public List<Bills> GetAll()
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.Bills_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Bills> list = new List<Bills>();

            while (reader.Read())
            {
                Bills b = new Bills
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    TableID = Convert.ToInt32(reader["TableID"]),
                    Amount = Convert.ToInt32(reader["Amount"]),
                    Discount = reader["Discount"] == DBNull.Value ? 0f : Convert.ToSingle(reader["Discount"]),
                    Tax = reader["Tax"] == DBNull.Value ? 0f : Convert.ToSingle(reader["Tax"]),
                    Status = Convert.ToBoolean(reader["Status"]),
                    CheckoutDate = reader["CheckoutDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["CheckoutDate"]),
                    Account = reader["Account"].ToString()
                };
                list.Add(b);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(Bills b, int action)
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.Bills_InsertUpdateDelete;

            SqlParameter pID = new SqlParameter("@ID", SqlDbType.Int) { Direction = ParameterDirection.InputOutput };
            pID.Value = b.ID;
            cmd.Parameters.Add(pID);

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = b.Name ?? (object)DBNull.Value;
            cmd.Parameters.Add("@TableID", SqlDbType.Int).Value = b.TableID;
            cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = b.Amount;
            cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = b.Discount;
            cmd.Parameters.Add("@Tax", SqlDbType.Float).Value = b.Tax;
            cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = b.Status;
            cmd.Parameters.Add("@CheckoutDate", SqlDbType.SmallDateTime).Value = b.CheckoutDate ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Account", SqlDbType.NVarChar, 100).Value = b.Account ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0 && action == 0)
                return (int)cmd.Parameters["@ID"].Value;

            return result;
        }
    }
}
