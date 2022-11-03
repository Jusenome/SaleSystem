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

        public IQueryable<AppUser> ToList()
        {
            //new IQueryable<AppUser>();
            IQueryable<AppUser> users;

            try
            {
                users =
                    from u in db.AppUsers
                    select new AppUser
                    {
                        Id = u.Id,
                        Document = u.Document,
                        FullName = u.FullName,
                        Mail = u.Mail,
                        Password = u.Password,
                        IdRole = u.IdRole,
                        State = u.State
                    };

                //return users;
            }
            catch(Exception ex)
            {
                users = (IQueryable<AppUser>)new List<AppUser>();
            }

            return users;
        }

        public AppUser GetUserById(int id)
        {
            AppUser user = new AppUser();

            try
            {
                user = db.AppUsers.Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                user = new AppUser();
            }

            return user;
        }

        public string CreateUser(AppUser newUser)
        {
            string result = "";
            AppUser consultUser = db.AppUsers.Where(o => o.Document == newUser.Document).FirstOrDefault();

            try
            {
                if (consultUser == null)
                {
                    AppUser user = new AppUser()
                    {
                        Document = newUser.Document,
                        FullName = newUser.FullName,
                        Mail = newUser.Mail,
                        Password = newUser.Password,
                        IdRole = newUser.IdRole,
                        State = newUser.State
                    };

                    db.Add(user);
                    db.SaveChanges();

                    result = "Usuario " + newUser.FullName + " creado correctamente.";
                }
                else
                {
                    result = "Error: El usuario con CC: " + newUser.Document + " ya existe en base de datos";
                }
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.Message;
            }

            return result;
        }

        public string UpdateUser(int id, AppUser dataUserUpdate)
        {
            AppUser user = new AppUser();
            string result = "";
            try
            {
                user = db.AppUsers.Where(o => o.Id == id).FirstOrDefault();
                AppUser dataUser = db.AppUsers.Where(o => o.Document == dataUserUpdate.Document).FirstOrDefault();
                
                if(dataUser == null || user.Id == dataUser.Id)
                {
                    user.Id = dataUserUpdate.Id;
                    user.Document = dataUserUpdate.Document;
                    user.FullName = dataUserUpdate.FullName;
                    user.Mail = dataUserUpdate.Mail;
                    user.Password = dataUserUpdate.Password;
                    user.IdRole = dataUserUpdate.IdRole;
                    user.State = dataUserUpdate.State;

                    db.SaveChanges();

                    result = "El usuario " + user.Document + " se ha editado correctamente.";
                }
                else
                {
                    result = "Error: El usuario con CC: " + user.Document + " no se ha editato. Esta intentando editar la cédula y ya pertenece a otro usuario";
                }
                
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
            }

            return result;
        }
    }
}
