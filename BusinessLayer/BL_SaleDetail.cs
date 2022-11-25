using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BL_SaleDetail
    {
        DL_SaleDetail oDLSaleDetail = new DL_SaleDetail();

        public List<SaleDetail> GetSaleDetailsBySaleId(int saleId)
        {
            return oDLSaleDetail.GetSaleDetailsBySaleId(saleId);
        }

        public string CreateSaleDetail(SaleDetail saleDetail)
        {
            return oDLSaleDetail.CreateSaleDetail(saleDetail);
        }
    }
}
