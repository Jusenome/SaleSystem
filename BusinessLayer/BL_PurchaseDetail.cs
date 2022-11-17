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

        public List<PurchaseDetail> GetPurchaseDetailsByPurchaseId(int purchaseId)
        {
            return oDLPurchaseDetail.GetPurchaseDetailsByPurchaseId(purchaseId);
        }

        public string CreatePurchaseDetail(PurchaseDetail purchaseDetail)
        {
            return oDLPurchaseDetail.CreatePurchaseDetail(purchaseDetail);
        }
    }
}
