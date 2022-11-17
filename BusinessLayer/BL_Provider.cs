using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BL_Provider
    {
        private DL_Provider oDLProvider = new DL_Provider();

        public IQueryable<Provider> GetProviders()
        {
            return oDLProvider.GetProviders();
        }

        public Provider GetProviderById(int id)
        {
            return oDLProvider.GetProviderById(id);
        }

        public string CreateProvider(Provider provider)
        {
            string result = oDLProvider.CreateProvider(provider);

            return result;
        }

        public string UpdateProvider(int id, Provider dataProviderUpdate)
        {
            string result = oDLProvider.UpdateProvider(id, dataProviderUpdate);

            return result;
        }
    }
}
