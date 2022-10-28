using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BL_Role
    {
        private DL_Role oRole = new DL_Role();

        public Role GetRole(int idRole)
        {
            return oRole.GetRole(idRole);
        }
    }
}
