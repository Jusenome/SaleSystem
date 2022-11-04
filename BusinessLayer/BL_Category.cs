using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class BL_Category
    {
        private DL_Category oDLCategory = new DL_Category();

        public IQueryable<Category> GetCategoryList()
        {
            return oDLCategory.GetCategoryList();
        }

        public Category GetCategoryById(int id)
        {
            return oDLCategory.GetCategoryById(id);
        }

        public string CreateCategory(Category category)
        {
            string result = oDLCategory.CreateCategory(category);

            return result;
        }

        public string UpdateCategory(int id, Category dataCategoryUpdate)
        {
            string result = oDLCategory.UpdateCategory(id, dataCategoryUpdate);

            return result;
        }
    }
}
