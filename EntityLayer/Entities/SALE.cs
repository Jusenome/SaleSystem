using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class SALE
    {
        public int id { get; set; }
        public APP_USER oUser { get; set; }
        public string document_type { get; set; }
        public string invoice_number { get; set; }
        public string client_document { get; set; }
        public string client_name { get; set; }
        public decimal payment { get; set; }
        public decimal change { get; set; }
        public decimal total { get; set; }
        public List<SALE_DETAIL> lSale_Detail { get; set; }
        public string creation_date { get; set; }
    }
}
