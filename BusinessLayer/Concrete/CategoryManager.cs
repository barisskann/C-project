using BusinessLayer.Abstract;
using DataAccesLayer.EntityFramework;
using DataAccesLayer.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategory efcategory;
        public CategoryManager()
        {
            efcategory = new EFCategory();
        }
        public void CategoryAdd(Category category)
        {
           efcategory.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            efcategory.Remove(category);
        }

        public void CategoryUpdate(Category category)
        {
            efcategory.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return efcategory.Get();
        }

        public Category GetCategory(int id)
        {
            return efcategory.GetAt(id);
        }
    }
}
