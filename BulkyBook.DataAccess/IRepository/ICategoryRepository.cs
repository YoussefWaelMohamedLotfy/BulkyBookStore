using BulkyBook.Models;

namespace BulkyBook.DataAccess.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
