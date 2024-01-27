using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public List<Category> GetCategoriesBySearch(string search)
        {
            using var c = new Context();
            return c.Categories.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToList();
        }

        public Category GetCategoryWithIdentityName(string name)
        {
            using var c = new Context();
            return c.Categories.FirstOrDefault(x => x.Name == name);
        }
    }
}
