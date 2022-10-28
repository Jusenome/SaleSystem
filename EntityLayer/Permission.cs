using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int? IdRole { get; set; }
        public string MenuName { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
    }
}
