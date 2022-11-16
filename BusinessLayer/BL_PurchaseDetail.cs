using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BL_PurchaseDetail
    {
        DL_PurchaseDetail oDLPurchaseDetail = new DL_PurchaseDetail();

        public string CreatePurchaseDetail(PurchaseDetail purchaseDetail)
        {
            return oDLPurchaseDetail.CreatePurchaseDetail(purchaseDetail);
        }
    }
}
