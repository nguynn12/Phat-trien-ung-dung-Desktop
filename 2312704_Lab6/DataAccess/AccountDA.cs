using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDA
    {
        public List<Account> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = Utilities.Account_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Account> list = new List<Account>();

            while (reader.Read())
            {
                Account account = new Account();
                account.AccountName = reader["AccountName"].ToString();
                account.Password = reader["Password"].ToString();
                account.FullName = reader["FullName"].ToString();
                account.Email = reader["Email"].ToString();
                account.Tell = reader["Tell"].ToString();
                account.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                list.Add(account);
            }

            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(Account account, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Account_InsertUpdateDelete;

            command.Parameters.AddWithValue("@AccountName", account.AccountName);
            command.Parameters.AddWithValue("@Password", account.Password);
            command.Parameters.AddWithValue("@FullName", account.FullName);
            command.Parameters.AddWithValue("@Email", account.Email);
            command.Parameters.AddWithValue("@Tell", account.Tell);
            command.Parameters.AddWithValue("@DateCreated", account.DateCreated);
            command.Parameters.AddWithValue("@Action", action);

            int result = command.ExecuteNonQuery();
            return result > 0 ? 1 : 0;  // Không có ID output vì PK là string
        }
    }
}
