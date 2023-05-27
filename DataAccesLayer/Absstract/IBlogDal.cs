using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Absstract
{
    public interface IBlogDal
    {
        List<Blog> GetAllBlog();
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);

        void UpdateBlog(Blog blog);
        Blog getById(int id);
    }
}
