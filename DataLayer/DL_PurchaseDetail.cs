using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_PurchaseDetail
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public List<PurchaseDetail> GetPurchaseDetailsByPurchaseId(int purchaseId)
        {
            return db.PurchaseDetails.Where(o => o.IdPurchase == purchaseId).ToList();
        }

        public string CreatePurchaseDetail(PurchaseDetail newPurchaseDetail)
        {
            string result = "";

            try
            {
                PurchaseDetail purchaseDetail = new PurchaseDetail()
                {
                    IdPurchase = newPurchaseDetail.IdPurchase,
                    IdProduct = newPurchaseDetail.IdProduct,
                    PurchasePrice = newPurchaseDetail.PurchasePrice,
                    SalePrice = newPurchaseDetail.SalePrice,
                    Quantity = newPurchaseDetail.Quantity,
                    Total = newPurchaseDetail.Total,
                };

                db.Add(newPurchaseDetail);
                db.SaveChanges();

                result = "Ok";
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.Message;
            }

            return result;
        }
    }
}
