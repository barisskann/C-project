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
        public List<Blog> Get()
        {
            throw new NotImplementedException();
        }

        public Blog GetAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Blog item)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog item)
        {
            throw new NotImplementedException();
        }
    }
}
