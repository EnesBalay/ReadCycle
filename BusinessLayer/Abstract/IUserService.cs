using EntityLayer.Concrete;

namespace BussinessLayer.Abstract
{
    public interface IUserService:IGenericService<User>
    {
        public User GetUserByEmail(String userName);
        public List<User> GetUserBySearch(String search);
    }
}
