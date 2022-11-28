using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class ReportSale
    {
        public string DocumentType { get; set; }
        public string InvoiceNumber { get; set; }
        public string UserName { get; set; }
        public string ClientDocument { get; set; }
        public string ClientName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string SalePrice { get; set; }
        public string Quantity { get; set; }
        public string SubTotal { get; set; }
        public string DateRegister { get; set; }
    }
}
