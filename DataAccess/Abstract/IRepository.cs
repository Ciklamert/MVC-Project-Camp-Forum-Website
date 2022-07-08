using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T> //Generic
    {
      
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        List<T> List(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
    }
}
