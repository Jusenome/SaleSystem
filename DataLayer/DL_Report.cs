using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataLayer
{
    public class DL_Report
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public IQueryable<ReportPurchase> PurchaseReport(string initialDate, string finalDate, int providerId)
        {
            var purchases = (from p in db.Purchases
                                              join u in db.AppUsers on p.IdUser equals u.Id
                                              join pr in db.Providers on p.IdProvider equals pr.Id
                                              join pd in db.PurchaseDetails on p.Id equals pd.IdPurchase
                                              join pro in db.Products on pd.IdProduct equals pro.Id
                                              join ca in db.Categories on pro.IdCategory equals ca.Id
                             where (p.CreationDate >= Convert.ToDateTime(initialDate) && p.CreationDate <= Convert.ToDateTime(finalDate)) &&  p.IdProvider == providerId
                                              select new ReportPurchase()
                                              {
                                                  
                                                    DocumentType = p.DocumentType,
                                                    InvoiceNumber = p.InvoiceNumber,
                                                    UserName = u.FullName,
                                                    ProviderDocument = pr.Document,
                                                    ProviderName = pr.BusinessName,
                                                    ProductCode = pro.Code,
                                                    ProductName = pro.Name,
                                                    Category = ca.Description,
                                                    PurchasePrice = pd.PurchasePrice.ToString(),
                                                    SalePrice = pd.SalePrice.ToString(),
                                                    Quantity = pd.Quantity.ToString(),
                                                    SubTotal = pd.Total.ToString(),
                                                    DateRegister = p.CreationDate.ToString()
                                                  

                                               });

            return purchases;
        }

        public IQueryable<ReportPurchase> PurchaseReportAll(string initialDate, string finalDate)
        {
            var purchases = (from p in db.Purchases
                             join u in db.AppUsers on p.IdUser equals u.Id
                             join pr in db.Providers on p.IdProvider equals pr.Id
                             join pd in db.PurchaseDetails on p.Id equals pd.IdPurchase
                             join pro in db.Products on pd.IdProduct equals pro.Id
                             join ca in db.Categories on pro.IdCategory equals ca.Id
                             where (p.CreationDate >= Convert.ToDateTime(initialDate) && p.CreationDate <= Convert.ToDateTime(finalDate))
                             select new ReportPurchase()
                             {

                                 DocumentType = p.DocumentType,
                                 InvoiceNumber = p.InvoiceNumber,
                                 UserName = u.FullName,
                                 ProviderDocument = pr.Document,
                                 ProviderName = pr.BusinessName,
                                 ProductCode = pro.Code,
                                 ProductName = pro.Name,
                                 Category = ca.Description,
                                 PurchasePrice = pd.PurchasePrice.ToString(),
                                 SalePrice = pd.SalePrice.ToString(),
                                 Quantity = pd.Quantity.ToString(),
                                 SubTotal = pd.Total.ToString(),
                                 DateRegister = p.CreationDate.ToString()


                             });

            return purchases;
        }


        public IQueryable<ReportSale> SaleReport(string initialDate, string finalDate)
        {
            var sales = (from s in db.Sales
                             join u in db.AppUsers on s.IdUser equals u.Id
                             join sd in db.SaleDetails on s.Id equals sd.IdSale
                             join pro in db.Products on sd.IdProduct equals pro.Id
                             join ca in db.Categories on pro.IdCategory equals ca.Id
                         where (s.CreationDate >= Convert.ToDateTime(initialDate) && s.CreationDate <= Convert.ToDateTime(finalDate))
                         select new ReportSale()
                             {

                                 DocumentType = s.DocumentType,
                                 InvoiceNumber = s.InvoiceNumber,
                                 UserName = u.FullName,
                                 ClientDocument = s.ClientDocument,
                                 ClientName = s.ClientName,
                                 ProductCode = pro.Code,
                                 ProductName = pro.Name,
                                 Category = ca.Description,
                                 SalePrice = sd.SalePrice.ToString(),
                                 Quantity = sd.Quantity.ToString(),
                                 SubTotal = sd.Subtotal.ToString(),
                                 DateRegister = s.CreationDate.ToString()


                             });

            return sales;
        }
    }
}
