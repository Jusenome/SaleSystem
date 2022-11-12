using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class DL_Category
    {
        DB_SALE_SYSTEMContext db = new DB_SALE_SYSTEMContext();

        public IQueryable<Category> GetCategoryList()
        {
            //new IQueryable<AppUser>();
            IQueryable<Category> categories;

            try
            {
                categories =
                    from u in db.Categories
                    select new Category
                    {
                        Id = u.Id,
                        Description = u.Description,
                        State = u.State
                    };

                //return users;
            }
            catch
            {
                categories = (IQueryable<Category>)new List<Category>();
            }

            return categories;
        }

        public Category GetCategoryById(int id)
        {
            Category category = new Category();

            try
            {
                category = db.Categories.Where(o => o.Id == id).FirstOrDefault();
            }
            catch
            {
                category = new Category();
            }

            return category;
        }

        public string CreateCategory(Category newCategory)
        {
            string result = "";
            Category consultCategory = db.Categories.Where(o => o.Description == newCategory.Description).FirstOrDefault();

            try
            {
                if (consultCategory == null)
                {
                    Category user = new Category()
                    {
                        Description = newCategory.Description,
                        State = newCategory.State
                    };

                    db.Add(user);
                    db.SaveChanges();

                    result = "Categoria " + newCategory.Description + " creado correctamente.";
                }
                else
                {
                    result = "Error: La categoria: " + newCategory.Description + " ya existe en base de datos";
                }
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.Message;
            }

            return result;
        }

        public string UpdateCategory(int id, Category dataCategoryUpdate)
        {
            Category category = new Category();
            string result = "";
            try
            {
                category = db.Categories.Where(o => o.Id == id).FirstOrDefault();
                Category dataCategory = db.Categories.Where(o => o.Description == dataCategoryUpdate.Description).FirstOrDefault();

                if (dataCategory == null || category.Description == dataCategory.Description)
                {
                    category.Id = dataCategoryUpdate.Id;
                    category.Description = dataCategoryUpdate.Description;
                    category.State = dataCategoryUpdate.State;

                    db.SaveChanges();

                    result = "La categoria " + dataCategoryUpdate.Description + " se ha editado correctamente.";
                }
                else
                {
                    result = "Error: La categoria: " + category.Description + " no se ha editato. Ya existe una categoria con esa descripción";
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
