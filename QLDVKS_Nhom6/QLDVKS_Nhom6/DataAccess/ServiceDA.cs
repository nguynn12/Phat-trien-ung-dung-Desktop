using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceDA
    {
        public List<Service> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Service_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Service> list = new List<Service>();

            while (reader.Read())
            {
                Service service = new Service();
                service.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                service.ServiceName = reader["ServiceName"].ToString();
                service.Price = Convert.ToDecimal(reader["Price"]);
                service.ServiceTypeID = Convert.ToInt32(reader["ServiceTypeID"]);
                service.TypeName = reader["TypeName"].ToString();
                list.Add(service);
            }

            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(Service service, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Service_InsertUpdateDelete;

            SqlParameter idPara = new SqlParameter("@ServiceID", SqlDbType.Int);
            idPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(idPara).Value = service.ServiceID;

            command.Parameters.Add("@ServiceName", SqlDbType.NVarChar, 100).Value = service.ServiceName;
            command.Parameters.Add("@Price", SqlDbType.Money).Value = service.Price;
            command.Parameters.Add("@ServiceTypeID", SqlDbType.Int).Value = service.ServiceTypeID;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();

            if (result > 0)
                return (int)command.Parameters["@ServiceID"].Value;
            return 0;
        }
    }
}
