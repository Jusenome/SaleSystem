using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_Provider
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public IQueryable<Provider> GetProviders()
        {
            IQueryable<Provider> providers;

            try
            {
                providers =
                    from c in db.Providers
                    select new Provider
                    {
                        Id = c.Id,
                        Document = c.Document,
                        BusinessName = c.BusinessName,
                        Mail = c.Mail,
                        Address = c.Address,
                        Phone = c.Phone,
                        State = c.State
                    };

                //return users;
            }
            catch
            {
                providers = (IQueryable<Provider>)new List<Provider>();
            }

            return providers;
        }

        public Provider GetProviderById(int id)
        {
            Provider provider = new Provider();

            try
            {
                provider = db.Providers.Where(o => o.Id == id).FirstOrDefault();
            }
            catch
            {
                provider = new Provider();
            }

            return provider;
        }

        public string CreateProvider(Provider newProvider)
        {
            string result = "";
            Provider consultProvider = db.Providers.Where(o => o.Document == newProvider.Document).FirstOrDefault();

            try
            {
                if (consultProvider == null)
                {
                    Provider provider = new Provider()
                    {
                        Document = newProvider.Document,
                        BusinessName = newProvider.BusinessName,
                        Mail = newProvider.Mail,
                        Address = newProvider.Address,
                        Phone = newProvider.Phone,
                        State = newProvider.State
                    };

                    db.Add(provider);
                    db.SaveChanges();

                    result = "El proveedor " + newProvider.BusinessName + " se ha creado correctamente.";
                }
                else
                {
                    result = "Error: El proveedor con identificación: " + newProvider.Document + " ya existe en base de datos";
                }
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.Message;
            }

            return result;
        }

        public string UpdateProvider(int id, Provider dataProviderUpdate)
        {
            Provider provider = new Provider();
            string result = "";
            try
            {
                provider = db.Providers.Where(o => o.Id == id).FirstOrDefault();
                Provider dataProvider = db.Providers.Where(o => o.Document == dataProviderUpdate.Document).FirstOrDefault();

                if (dataProvider == null || provider.Id == dataProvider.Id)
                {
                    provider.Id = dataProviderUpdate.Id;
                    provider.Document = dataProviderUpdate.Document;
                    provider.BusinessName = dataProviderUpdate.BusinessName;
                    provider.Mail = dataProviderUpdate.Mail;
                    provider.Address = dataProviderUpdate.Address;
                    provider.Phone = dataProviderUpdate.Phone;
                    provider.State = dataProviderUpdate.State;

                    db.SaveChanges();

                    result = "El proveedor " + provider.BusinessName + " se ha editado correctamente.";
                }
                else
                {
                    result = "Error: El proveedor con identificación: " + provider.Document + " no se ha editato. Esta intentando editar la identificación y ya pertenece a otro proveedor";
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
