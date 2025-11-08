using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleAccountDA
    {
        public List<RoleAccount> GetAll()
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.RoleAccount_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<RoleAccount> list = new List<RoleAccount>();

            while (reader.Read())
            {
                RoleAccount ra = new RoleAccount
                {
                    RoleID = Convert.ToInt32(reader["RoleID"]),
                    AccountName = reader["AccountName"].ToString(),
                    Actived = Convert.ToBoolean(reader["Actived"]),
                    Notes = reader["Notes"].ToString()
                };
                list.Add(ra);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(RoleAccount ra, int action)
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.RoleAccount_InsertUpdateDelete;

            cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = ra.RoleID;
            cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = ra.AccountName ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Actived", SqlDbType.Bit).Value = ra.Actived;
            cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = ra.Notes ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            return cmd.ExecuteNonQuery();
        }
    }
}
