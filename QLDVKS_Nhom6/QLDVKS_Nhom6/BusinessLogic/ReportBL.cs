using DataAccess;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ReportBL
    {
        ReportDA reportDA = new ReportDA();

        public List<RevenueReportItem> GetRevenue(DateTime tuNgay, DateTime denNgay, int groupType)
        {
            return reportDA.GetRevenue(tuNgay, denNgay, groupType);
        }
    }
}