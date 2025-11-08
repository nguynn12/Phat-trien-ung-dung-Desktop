using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillDetailsDA
    {
        public List<BillDetails> GetAll()
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.BillDetails_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<BillDetails> list = new List<BillDetails>();

            while (reader.Read())
            {
                BillDetails bd = new BillDetails
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    InvoiceID = Convert.ToInt32(reader["InvoiceID"]),
                    FoodID = Convert.ToInt32(reader["FoodID"]),
                    Quantity = Convert.ToInt32(reader["Quantity"])
                };

                list.Add(bd);
            }

            conn.Close();
            return list;
        }

        public int Insert_Update_Delete(BillDetails bd, int action)
        {
            SqlConnection conn = new SqlConnection(Utilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Utilities.BillDetails_InsertUpdateDelete;

            SqlParameter pID = new SqlParameter("@ID", SqlDbType.Int) { Direction = ParameterDirection.InputOutput };
            pID.Value = bd.ID;
            cmd.Parameters.Add(pID);

            cmd.Parameters.Add("@InvoiceID", SqlDbType.Int).Value = bd.InvoiceID;
            cmd.Parameters.Add("@FoodID", SqlDbType.Int).Value = bd.FoodID;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = bd.Quantity;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0 && action == 0)   // Insert trả về ID mới
                return (int)cmd.Parameters["@ID"].Value;

            return result;
        }
    }
}
