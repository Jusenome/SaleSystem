using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_Purchase
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();
        public string CreatePurchase(Purchase newPurchase)
        {
            string result = "";
            Purchase consultPurchase = db.Purchases.Where(o => o.InvoiceNumber == newPurchase.InvoiceNumber).FirstOrDefault();

            try
            {
                if (consultPurchase == null)
                {
                    Purchase purchase = new Purchase()
                    {
                        IdUser = newPurchase.IdUser,
                        IdProvider = newPurchase.IdProvider,
                        DocumentType = newPurchase.DocumentType,
                        InvoiceNumber = newPurchase.InvoiceNumber,
                        Total = newPurchase.Total,
                    };

                    db.Add(purchase);
                    db.SaveChanges();

                    result = "Compra " + newPurchase.InvoiceNumber + " creada correctamente.";
                }
                else
                {
                    result = "Error: No se pudo guardar la compra";
                }
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.Message;
            }

            return result;
        }
    }
}
