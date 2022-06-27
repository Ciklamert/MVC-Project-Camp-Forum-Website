using DataAccess.Concrete.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();
        //CRUD işlemleri

        public List<Category> GetAll()
        {
            return repository.List();
        }
        public void Add(Category category)
        {
            if(category.CategoryName == "" || category.CategoryName.Length <= 3 || category.CategoryDescription == "")
            {
                Console.WriteLine("You cannot add this item");
                return;
            }
            repository.Insert(category);
        }
    }
       
}
