using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BL_Sale
    {
        private DL_Sale oDLSale = new DL_Sale();

        public Sale GetSaleByInvoiceNumber(string invoiceNumber)
        {
            return oDLSale.GetSaleByInvoiceNumber(invoiceNumber);
        }

        public string CreateSale(Sale sale)
        {
            return oDLSale.CreateSale(sale);
        }
    }
}
