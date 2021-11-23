using BulkyBook.Models;

namespace BulkyBook.DataAccess.IRepository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);
    }
}
