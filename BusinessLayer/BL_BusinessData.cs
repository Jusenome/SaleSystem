using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BL_BusinessData
    {
        DL_BusinessData oDLBusiness = new DL_BusinessData();

        public BusinessData GetBusinessData()
        {
            return oDLBusiness.GetBusinessData();
        }

        public BusinessData GetBusinessById(string nit)
        {
            return oDLBusiness.GetBusinessById(nit);
        }

        public string CreateBusiness(BusinessData newBusiness)
        {
            return oDLBusiness.CreateBusiness(newBusiness);
        }

        public string UpdateBusiness(string nit, BusinessData dataBusinessUpdate)
        {
            return oDLBusiness.UpdateBusiness(nit, dataBusinessUpdate);
        }

        public byte[] GetLogo()
        {
            return oDLBusiness.GetLogo();
        }
    }
}
