using System;
using System.Collections.Generic;

#nullable disable

namespace EntityLayer
{
    public partial class BusinessData
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public byte[] Logo { get; set; }
    }
}
