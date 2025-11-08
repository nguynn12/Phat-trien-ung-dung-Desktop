using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleDA
    {
        public List<Role> GetAll()
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.Role_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Role> list = new List<Role>();

            while (reader.Read())
            {
                Role r = new Role
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    RoleName = reader["RoleName"].ToString(),
                    Path = reader["Path"].ToString(),
                    Notes = reader["Notes"].ToString()
                };
                list.Add(r);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(Role r, int action)
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.Role_InsertUpdateDelete;

            SqlParameter pID = new SqlParameter("@ID", SqlDbType.Int) { Direction = ParameterDirection.InputOutput };
            pID.Value = r.ID;
            cmd.Parameters.Add(pID);

            cmd.Parameters.Add("@RoleName", SqlDbType.NVarChar, 1000).Value = r.RoleName ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Path", SqlDbType.NVarChar, 3000).Value = r.Path ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = r.Notes ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0 && action == 0)
                return (int)cmd.Parameters["@ID"].Value;

            return result;
        }
    }
}
