using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ReportDA
    {
        public List<RevenueReportItem> GetRevenue(DateTime tuNgay, DateTime denNgay, int groupType)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Report_GetRevenueByRange; // SP MỚI

            command.Parameters.Add("@TuNgay", SqlDbType.Date).Value = tuNgay;
            command.Parameters.Add("@DenNgay", SqlDbType.Date).Value = denNgay;
            command.Parameters.Add("@GroupByType", SqlDbType.Int).Value = groupType;

            SqlDataReader reader = command.ExecuteReader();
            List<RevenueReportItem> list = new List<RevenueReportItem>();

            while (reader.Read())
            {
                RevenueReportItem item = new RevenueReportItem();
                item.NgayThangNam = reader["NgayThangNam"].ToString();
                item.SoHoaDon = Convert.ToInt32(reader["SoHoaDon"]);
                item.DoanhThu = Convert.ToDecimal(reader["DoanhThu"]);
                list.Add(item);
            }

            sqlConn.Close();
            return list;
        }
    }
}