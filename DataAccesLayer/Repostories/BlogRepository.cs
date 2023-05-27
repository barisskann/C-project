using DataAccesLayer.Absstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repostories
{
    internal class BlogRepository : IBlogDal
    {
        Context c = new Context();
        public void AddBlog(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();

        }

        public void DeleteBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }

        public List<Blog> GetAllBlog()
        {
            return c.Blogs.ToList();
        }

        public Blog getById(int id)
        {
            return c.Blogs.Find(id);
        }

        public void UpdateBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
