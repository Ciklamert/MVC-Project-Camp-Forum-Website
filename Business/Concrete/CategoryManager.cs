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

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
        //CRUD işlemleri

        /*
        public void Add(Category category)
        {
            
            if(category.CategoryName == "" || category.CategoryStatus == false || category.CategoryName.Length <= 2)
            {
                
                // hata mesajı
            }
            else
            {
                _categoryDal.Insert(category);
            }
           
            
        }
       */
    }
       
}
