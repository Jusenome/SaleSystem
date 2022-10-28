using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class Provider
    {
        public Provider()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        public string Document { get; set; }
        public string BusinessName { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool? State { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
