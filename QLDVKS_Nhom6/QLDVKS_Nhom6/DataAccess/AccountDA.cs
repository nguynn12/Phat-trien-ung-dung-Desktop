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
        public Account Login(string username, string password)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Account_Login;

            command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
            command.Parameters.Add("@Password", SqlDbType.NVarChar, 64).Value = password;

            SqlDataReader reader = command.ExecuteReader();
            Account account = null;

            if (reader.Read())
            {
                account = new Account();
                account.DisplayName = reader["DisplayName"].ToString();
                account.RoleName = reader["RoleName"].ToString();
            }

            sqlConn.Close();
            return account;
        }

        public List<Account> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Account_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Account> list = new List<Account>();

            while (reader.Read())
            {
                Account acc = new Account();
                acc.Username = reader["Username"].ToString();
                acc.DisplayName = reader["DisplayName"].ToString();
                acc.RoleID = Convert.ToInt32(reader["RoleID"]);
                acc.RoleName = reader["RoleName"].ToString();
                list.Add(acc);
            }
            sqlConn.Close();
            return list;
        }

        public int InsertUpdateDelete(Account acc, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Account_InsertUpdateDelete;

            command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = acc.Username;

            // Chỉ cần 2 tham số này khi Thêm hoặc Sửa
            if (action == 0 || action == 1)
            {
                command.Parameters.Add("@DisplayName", SqlDbType.NVarChar, 100).Value = acc.DisplayName;
                command.Parameters.Add("@RoleID", SqlDbType.Int).Value = acc.RoleID;
            }

            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result;
        }

        public int ResetPassword(string username, string newPassword)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Account_ResetPassword;

            command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
            command.Parameters.Add("@NewPassword", SqlDbType.NVarChar, 64).Value = newPassword;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result;
        }
    }
}
