using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class AppUser
    {
        public AppUser()
        {
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Document { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int? IdRole { get; set; }
        public bool? State { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
