using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        public Category GetCategoryWithIdentityName(string name);
        public List<Category> GetCategoriesBySearch(string search);
    }
}
