namespace CarbonQuest.Lib.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T? GetById(string id);
        void Add(T item);
        void SaveChanges();
    }
}
