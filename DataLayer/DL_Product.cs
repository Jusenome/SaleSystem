using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_Product
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public IQueryable<Product> GetProducts()
        {
            //new IQueryable<AppUser>();
            IQueryable<Product> products;

            try
            {
                products =
                    from u in db.Products
                    select new Product
                    {
                        Id = u.Id,
                        Code = u.Code,
                        Name = u.Name,
                        Description = u.Description,
                        IdCategory = u.IdCategory,
                        Stock = u.Stock,
                        PurchasePrice = u.PurchasePrice,
                        SalePrice = u.SalePrice,
                        State = u.State
                    };

                //return users;
            }
            catch
            {
                products = (IQueryable<Product>)new List<Product>();
            }

            return products;
        }

        public Product GetProductById(int id)
        {
            Product product = new Product();

            try
            {
                product = db.Products.Where(o => o.Id == id).FirstOrDefault();
            }
            catch
            {
                product = new Product();
            }

            return product;
        }

        public string CreateProduct(Product newProduct)
        {
            string result = "";
            Product consultProduct = db.Products.Where(o => o.Code == newProduct.Code).FirstOrDefault();

            try
            {
                if (consultProduct == null)
                {
                    Product product = new Product()
                    {
                        Code = newProduct.Code,
                        Name = newProduct.Name,
                        Description = newProduct.Description,
                        IdCategory = newProduct.IdCategory,
                        State = newProduct.State
                    };

                    db.Add(product);
                    db.SaveChanges();

                    result = "Producto " + newProduct.Code + " creado correctamente.";
                }
                else
                {
                    result = "Error: El producto con codigo: " + newProduct.Code + " ya existe en base de datos";
                }
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.Message;
            }

            return result;
        }

        public string UpdateProduct(int id, Product dataProductUpdate)
        {
            Product product = new Product();
            string result = "";
            try
            {
                product = db.Products.Where(o => o.Id == id).FirstOrDefault();
                Product dataProduct = db.Products.Where(o => o.Code == dataProductUpdate.Code).FirstOrDefault();

                if (dataProduct == null || product.Id == dataProduct.Id)
                {
                    product.Id = dataProductUpdate.Id;
                    product.Code = dataProductUpdate.Code;
                    product.Name = dataProductUpdate.Name;
                    product.Description = dataProductUpdate.Description;
                    product.IdCategory = dataProductUpdate.IdCategory;
                    product.State = dataProductUpdate.State;

                    db.SaveChanges();

                    result = "El producto " + product.Code + " se ha editado correctamente.";
                }
                else
                {
                    result = "Error: El producto con codigo: " + product.Code + " no se ha editato. Esta intentando editar el codigo y ya pertenece a otro producto";
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
