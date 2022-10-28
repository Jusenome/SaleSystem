using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class Sale
    {
        public Sale()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string DocumentType { get; set; }
        public string InvoiceNumber { get; set; }
        public string ClientDocument { get; set; }
        public string ClientName { get; set; }
        public decimal? Payment { get; set; }
        public decimal? Change { get; set; }
        public decimal? Total { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual AppUser IdUserNavigation { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
