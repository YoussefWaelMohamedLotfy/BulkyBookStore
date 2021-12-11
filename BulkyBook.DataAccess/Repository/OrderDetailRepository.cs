using BulkyBook.Data;
using BulkyBook.DataAccess.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
