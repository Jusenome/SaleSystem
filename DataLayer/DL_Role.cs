using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_Role
    {
        public Role GetRole(int idRole)
        {
            Role role = new Role();
            DBContext.DB_SALE_SYSTEMContext db = new DBContext.DB_SALE_SYSTEMContext();

            try
            {
                role = db.Roles.Where(o => o.Id == idRole).FirstOrDefault();
            }
            catch (Exception ex)
            {
                role = new Role();
            }

            return role;
        }

        public List<Role> GetRoleList()
        {
            List<Role> roles = new List<Role>();
            DBContext.DB_SALE_SYSTEMContext db = new DBContext.DB_SALE_SYSTEMContext();

            try
            {
                roles = db.Roles.ToList();
            }
            catch(Exception ex)
            {
                roles = new List<Role>();
            }

            return roles;
        }
    }
}
