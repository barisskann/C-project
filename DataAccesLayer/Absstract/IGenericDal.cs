using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Absstract
{
    internal interface IGenericDal<T> where T : class
    {
        void Insert (T item);
        void Remove (T item);
        void Update (T item);
        List<T> Get();
        T GetAt (int index);
    }
}
