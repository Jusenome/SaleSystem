using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BL_Product
    {
        private DL_Product oDLProduct = new DL_Product();

        public IQueryable<Product> GetProducts()
        {
            return oDLProduct.GetProducts();
        }

        public string CreateProduct(Product product)
        {
            string result = oDLProduct.CreateProduct(product);

            return result;
        }

        public string UpdateProduct(int id, Product dataProductUpdate)
        {
            string result = oDLProduct.UpdateProduct(id, dataProductUpdate);

            return result;
        }
    }
}
