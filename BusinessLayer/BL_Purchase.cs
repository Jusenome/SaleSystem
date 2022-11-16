using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BL_Purchase
    {
        private DL_Purchase oDLPrurchase = new DL_Purchase();

        public string CreatePurchase(Purchase purchase)
        {
            return oDLPrurchase.CreatePurchase(purchase);
        }
    }
}
