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
        DBContext.DB_SALE_SYSTEMContext db = new DBContext.DB_SALE_SYSTEMContext();

        public List<AppUser> ToList()
        {
            List<AppUser> users = new List<AppUser>();

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

        public void CreateUser(string document, string fullName, string mail, string password, int idRole, bool state)
        {
            AppUser user = new AppUser()
            {
                Document = document,
                FullName = fullName,
                Mail = mail,
                Password = password,
                IdRole = idRole,
                State = state
            };

            db.Add(user);
            db.SaveChanges();
        }
    }
}
