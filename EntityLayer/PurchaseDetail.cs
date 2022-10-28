using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class PurchaseDetail
    {
        public int Id { get; set; }
        public int? IdPurchase { get; set; }
        public int? IdProduct { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int? Quantity { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual Purchase IdPurchaseNavigation { get; set; }
    }
}
