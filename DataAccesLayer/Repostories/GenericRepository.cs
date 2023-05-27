using DataAccesLayer.Absstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repostories
{
    internal class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public List<T> Get()
        {
            return c.Set<T>().ToList();
        }

        public T GetAt(int index)
        {
            return c.Set<T>().Find(index);
        }

        public void Insert(T item)
        {
            c.Add(item);
            c.SaveChanges();
        }

        public void Remove(T item)
        {
            c.Remove(item);
            c.SaveChanges();
        }

        public void Update(T item)
        {
            c.Update(item);
            c.SaveChanges();
        }
    }
}
