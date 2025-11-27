using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceTypeDA
    {
        public List<ServiceType> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.ServiceType_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<ServiceType> list = new List<ServiceType>();

            while (reader.Read())
            {
                ServiceType type = new ServiceType();
                type.ServiceTypeID = Convert.ToInt32(reader["ServiceTypeID"]);
                type.TypeName = reader["TypeName"].ToString();
                list.Add(type);
            }

            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(ServiceType type, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.ServiceType_InsertUpdateDelete;

            SqlParameter idPara = new SqlParameter("@ServiceTypeID", SqlDbType.Int);
            idPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(idPara).Value = type.ServiceTypeID;

            command.Parameters.Add("@TypeName", SqlDbType.NVarChar, 50).Value = type.TypeName;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();

            if (result > 0)
                return (int)command.Parameters["@ServiceTypeID"].Value;
            return 0;
        }
    }
}
