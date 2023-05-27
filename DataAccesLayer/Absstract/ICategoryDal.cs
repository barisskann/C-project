﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Absstract
{
    public interface ICategoryDal
    {
        List<Category> ListAllCategory();
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory (Category category);
        Category getById(int id);
    }
}
