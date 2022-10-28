using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BL_User
    {
        private DL_User oDLUser = new DL_User();

        public List<AppUser> ToList()
        {
            return oDLUser.ToList();
        }
        
    }
}
