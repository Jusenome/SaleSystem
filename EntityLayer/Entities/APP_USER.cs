using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class APP_USER
    {
        public int id { get; set; }
        public string document { get; set; }
        public string full_name { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public ROLE oRole { get; set; }
        public bool state { get; set; }
        public string creation_date { get; set; }
    }
}
