using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_Sale
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public Sale GetSaleByInvoiceNumber(string invoiceNumber)
        {
            return db.Sales.Where(o => o.InvoiceNumber == invoiceNumber).FirstOrDefault();
        }

        public string CreateSale(Sale newSale)
        {
            string result = "";
            Sale consultSale = db.Sales.Where(o => o.InvoiceNumber == newSale.InvoiceNumber).FirstOrDefault();

            try
            {
                if (consultSale == null)
                {
                    Sale purchase = new Sale()
                    {
                        IdUser = newSale.IdUser,
                        DocumentType = newSale.DocumentType,
                        InvoiceNumber = newSale.InvoiceNumber,
                        ClientDocument = newSale.ClientDocument,
                        ClientName = newSale.ClientName,
                        Payment = newSale.Payment,
                        Change = newSale.Change,
                        Total = newSale.Total,
                    };

                    db.Add(purchase);
                    db.SaveChanges();

                    result = "Venta " + newSale.InvoiceNumber + " creada correctamente.";
                }
                else
                {
                    result = "Error: No se pudo guardar la venta";
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
