using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_SaleDetail
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public List<SaleDetail> GetSaleDetailsBySaleId(int saleId)
        {
            return db.SaleDetails.Where(o => o.IdSale == saleId).ToList();
        }

        public string CreateSaleDetail(SaleDetail newSaleDetail)
        {
            string result = "";

            try
            {
                SaleDetail saleDetail = new SaleDetail()
                {
                    IdSale = newSaleDetail.IdSale,
                    IdProduct = newSaleDetail.IdProduct,
                    SalePrice = newSaleDetail.SalePrice,
                    Quantity = newSaleDetail.Quantity,
                    Subtotal = newSaleDetail.Subtotal,
                };

                db.Add(saleDetail);
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
