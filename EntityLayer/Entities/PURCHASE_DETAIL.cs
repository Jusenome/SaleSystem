using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class PURCHASE_DETAIL
    {
        public int id { get; set; }
        public PRODUCT oProduct { get; set; }
        public decimal purchase_price { get; set; }
        public decimal sale_price { get; set; }
        public int quantity { get; set; }
        public decimal total { get; set; }
        public string creation_date { get; set; }
    }
}
