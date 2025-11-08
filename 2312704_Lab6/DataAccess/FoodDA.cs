using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    public class FoodDA
    {
        public List<Food> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Food_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Food> list = new List<Food>();

            while (reader.Read())
            {
                Food food = new Food();
                food.ID = Convert.ToInt32(reader["ID"]);
                food.Name = reader["FoodName"].ToString();
                food.Unit = reader["Unit"].ToString();
                food.FoodCategoryID = Convert.ToInt32(reader["FoodCategoryID"]);
                food.Price = Convert.ToInt32(reader["Price"]);
                food.Notes = reader["Notes"].ToString();
                list.Add(food);
            }

            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(Food food, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Food_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;

            command.Parameters.Add(IDPara).Value = food.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000)
                .Value = food.Name;
            command.Parameters.Add("@Unit", SqlDbType.NVarChar)
                .Value = food.Unit;
            command.Parameters.Add("@FoodCategoryID", SqlDbType.Int)
                .Value = food.FoodCategoryID;
            command.Parameters.Add("@Price", SqlDbType.Int)
                .Value = food.Price;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000)
                .Value = food.Notes;
            command.Parameters.Add("@Action", SqlDbType.Int)
                .Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;

            return 0;
        }
    }
}
