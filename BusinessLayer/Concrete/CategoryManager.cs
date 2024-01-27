using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category t)
        {
            _categoryDal.Add(t);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetListAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetCategoryByName(string name)
        {
            return _categoryDal.GetCategoryWithIdentityName(name);
        }

        public List<Category> GetCategoryBySearch(string search)
        {
            return _categoryDal.GetCategoriesBySearch(search);
        }

        public void Remove(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void Update(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
