using BulkyBook.Models;

namespace BulkyBook.DataAccess.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType obj);
    }
}
