using BulkyBook.Data;
using BulkyBook.DataAccess.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
