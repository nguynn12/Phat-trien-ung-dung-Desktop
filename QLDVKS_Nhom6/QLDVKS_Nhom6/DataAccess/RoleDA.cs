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
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Role_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Role> list = new List<Role>();

            while (reader.Read())
            {
                Role role = new Role();
                role.RoleID = Convert.ToInt32(reader["RoleID"]);
                role.RoleName = reader["RoleName"].ToString();
                list.Add(role);
            }

            sqlConn.Close();
            return list;
        }
    }
}
