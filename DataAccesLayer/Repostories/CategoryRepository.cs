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
    public class CategoryRepository : IGenericDal<Category>
    {
        public List<Category> Get()
        {
            throw new NotImplementedException();
        }

        public Category GetAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category item)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
