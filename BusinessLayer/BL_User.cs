using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BL_User
    {
        private DL_User oDLUser = new DL_User();

        public IQueryable<AppUser> ToList()
        {
            return oDLUser.ToList();
        }

        public AppUser GetUserById(int id)
        {
            return oDLUser.GetUserById(id);
        }

        public string CreateUser(AppUser user)
        {
           string result = oDLUser.CreateUser(user);

            return result;
        }

        public string UpdateUser(int id, AppUser dataUserUpdate)
        {
            string result = oDLUser.UpdateUser(id, dataUserUpdate);

            return result;
        }
        
    }
}
