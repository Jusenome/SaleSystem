using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace DataLayer
{
    public class DL_User
    {
        public List<AppUser> ToList()
        {
            List<AppUser> users = new List<AppUser>();
            DBContext.DB_SALE_SYSTEMContext db = new DBContext.DB_SALE_SYSTEMContext();

            try
            {
                users = db.AppUsers.ToList();
            }
            catch(Exception ex)
            {
                users = new List<AppUser>();
            }

            return users;
        }
    }
}
