using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class SALE_DETAIL
    {
        public int id { get; set; }
        public PRODUCT oProduct { get; set; }
        public decimal sale_price { get; set; }
        public int quantity { get; set; }
        public decimal subtotal { get; set; }
        public string creation_date { get; set; }
    }
}
