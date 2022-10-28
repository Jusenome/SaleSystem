using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class PERMISSION
    {
        public int id { get; set; }
        public ROLE oRole { get; set; }
        public string menu_name { get; set; }
        public string creation_date { get; set; }
    }
}
