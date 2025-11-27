using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoomDA
    {
        public List<Room> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Room_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Room> list = new List<Room>();

            while (reader.Read())
            {
                Room room = new Room();
                room.RoomID = Convert.ToInt32(reader["RoomID"]);
                room.RoomName = reader["RoomName"].ToString();
                room.StatusID = Convert.ToInt32(reader["StatusID"]);
                list.Add(room);
            }

            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(Room room, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Room_InsertUpdateDelete;

            SqlParameter idPara = new SqlParameter("@RoomID", SqlDbType.Int);
            idPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(idPara).Value = room.RoomID;

            command.Parameters.Add("@RoomName", SqlDbType.NVarChar, 50).Value = room.RoomName;
            command.Parameters.Add("@StatusID", SqlDbType.Int).Value = room.StatusID;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();

            if (result > 0)
                return (int)command.Parameters["@RoomID"].Value;
            return 0;
        }
    }
}
