using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal) // dependency injection
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
        //CRUD işlemleri

        /*
        public List<Category> GetAll()
        {
            return repository.List();
        }
        public void Add(Category category)
        {
            
            if(category.CategoryName == "" || category.CategoryName.Length <= 3 || category.CategoryDescription == "")
            {
                

            }
            else
            {
                repository.Insert(category);
            }
           
            
        }
        */
    }
       
}
