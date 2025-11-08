using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RestaurantTableDA
    {
        public List<RestaurantTable> GetAll()
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.Table_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<RestaurantTable> list = new List<RestaurantTable>();

            while (reader.Read())
            {
                RestaurantTable t = new RestaurantTable
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    Status = Convert.ToInt32(reader["Status"]),
                    Capacity = reader["Capacity"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Capacity"])
                };
                list.Add(t);
            }
            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(RestaurantTable t, int action)
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.Table_InsertUpdateDelete;

            SqlParameter pID = new SqlParameter("@ID", SqlDbType.Int) { Direction = ParameterDirection.InputOutput };
            pID.Value = t.ID;
            cmd.Parameters.Add(pID);

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = t.Name ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Status", SqlDbType.Int).Value = t.Status;
            cmd.Parameters.Add("@Capacity", SqlDbType.Int).Value = t.Capacity ?? (object)DBNull.Value;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0 && action == 0)
                return (int)cmd.Parameters["@ID"].Value;

            return result;
        }
    }
}
