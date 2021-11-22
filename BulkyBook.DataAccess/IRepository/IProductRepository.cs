using BulkyBook.Models;

namespace BulkyBook.DataAccess.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
