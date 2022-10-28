using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class Product
    {
        public Product()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? IdCategory { get; set; }
        public int Stock { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public bool? State { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
