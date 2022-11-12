using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_BusinessData
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public BusinessData GetBusinessData()
        {
            BusinessData business;
            try
            {
                business = db.BusinessData.FirstOrDefault();
            }
            catch
            {
                business = new BusinessData();
            }

            return business;
        }

        public BusinessData GetBusinessById(string nit)
        {
            BusinessData business = new BusinessData();

            try
            {
                business = db.BusinessData.Where(o => o.Nit == nit).FirstOrDefault();
            }
            catch
            {
                business = new BusinessData();
            }

            return business;
        }

        public string CreateBusiness(BusinessData newBusiness)
        {
            string result = "";
            BusinessData consultBusiness = db.BusinessData.Where(o => o.Nit == newBusiness.Nit).FirstOrDefault();

            try
            {
                if (consultBusiness == null)
                {
                    BusinessData user = new BusinessData()
                    {
                        Nit = newBusiness.Nit,
                        Nombre = newBusiness.Nombre,
                        Address = newBusiness.Address,
                        Phone = newBusiness.Phone,
                        Logo = newBusiness.Logo
                    };

                    db.Add(user);
                    db.SaveChanges();

                    result = "Usuario " + newBusiness.Nombre + " creado correctamente.";
                }
                else
                {
                    result = "Error: El usuario con CC: " + newBusiness.Nit + " ya existe en base de datos";
                }
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.Message;
            }

            return result;
        }

        public string UpdateBusiness(string nit, BusinessData dataBusinessUpdate)
        {
            BusinessData business = new BusinessData();
            string result = "";
            try
            {
                business = db.BusinessData.Where(o => o.Nit == nit).FirstOrDefault();

                business.Nit = dataBusinessUpdate.Nit;
                business.Nombre = dataBusinessUpdate.Nombre;
                business.Address = dataBusinessUpdate.Address;
                business.Phone = dataBusinessUpdate.Phone;
                business.Logo = dataBusinessUpdate.Logo;

                db.SaveChanges();

                result = "Se actualizaron los datos correctamente";
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
            }

            return result;
        }

        public byte[] GetLogo()
        {
            byte[] logoBytes = new byte[0];
            try
            {
                logoBytes = db.BusinessData.FirstOrDefault().Logo;
            }
            catch
            {
                logoBytes = new byte[0];
            }
            return logoBytes;
        }
    }
}
