using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class Purchase
    {
        public Purchase()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        public int Id { get; set; }
        public int? IdUser { get; set; }
        public int? IdProvider { get; set; }
        public string DocumentType { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Provider IdProviderNavigation { get; set; }
        public virtual AppUser IdUserNavigation { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
