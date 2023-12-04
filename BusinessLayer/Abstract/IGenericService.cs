

namespace BussinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T t);
        void Remove(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetById(int id);
    }
}
