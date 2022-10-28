using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class PURCHASE
    {
        public int id { get; set; }
        public APP_USER oUser { get; set; }
        public PROVIDER oProvider { get; set; }
        public string document_type { get; set; }
        public string invoice_number { get; set; }
        public decimal total { get; set; }
        public List<PURCHASE_DETAIL> lPurchase_Detail { get; set; }
        public string creation_date { get; set; }
    }
}
