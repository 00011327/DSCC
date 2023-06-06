using LibraryUI.Models;

namespace LibraryUI.Repository
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        T GetById(int id);

        void Create(T entity);
        void Update(Book book);
        void Delete(int id);
    }
}
