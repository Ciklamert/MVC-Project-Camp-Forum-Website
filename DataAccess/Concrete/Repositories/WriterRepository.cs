using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(Writer item)
        {
            _object.Remove(item);
            c.SaveChanges();
        }

        public void Insert(Writer item)
        {
            _object.Add(item);
            c.SaveChanges();
        }

        public List<Writer> List()
        {
            return _object.ToList();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(Writer item)
        {
            c.SaveChanges();
        }
    }
}
