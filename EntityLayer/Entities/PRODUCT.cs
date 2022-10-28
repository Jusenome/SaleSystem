using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class PRODUCT
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public CATEGORY oCategory { get; set; }
        public int stock { get; set; }
        public decimal purchase_price { get; set; }
        public decimal sale_price { get; set; }
        public bool state { get; set; }
        public string creation_date { get; set; }
    }
}
