using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class Role
    {
        public Role()
        {
            AppUsers = new HashSet<AppUser>();
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
