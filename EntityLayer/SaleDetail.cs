using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class SaleDetail
    {
        public int Id { get; set; }
        public int? IdSale { get; set; }
        public int? IdProduct { get; set; }
        public decimal? SalePrice { get; set; }
        public int? Quantity { get; set; }
        public decimal? Subtotal { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual Sale IdSaleNavigation { get; set; }
    }
}
