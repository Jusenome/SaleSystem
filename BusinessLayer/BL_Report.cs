using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BL_Report
    {
        DL_Report oDLReport = new DL_Report();

        public IQueryable<ReportPurchase> PurchaseReport(string initialDate, string finalDate, int providerId)
        {
            return oDLReport.PurchaseReport(initialDate, finalDate, providerId);
        }

        public IQueryable<ReportPurchase> PurchaseReportAll(string initialDate, string finalDate)
        {
            return oDLReport.PurchaseReportAll(initialDate, finalDate);
        }

        public IQueryable<ReportSale> SaleReport (string initialDate, string finalDate)
        {
            return oDLReport.SaleReport(initialDate, finalDate);
        }
    }
}
