using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool? State { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
