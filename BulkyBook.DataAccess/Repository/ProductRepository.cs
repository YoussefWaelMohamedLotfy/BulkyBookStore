using AutoMapper;
using BulkyBook.Data;
using BulkyBook.DataAccess.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(Product obj)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, Product>());
            var mapper = config.CreateMapper();
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);

            if (objFromDb != null)
                mapper.Map(obj, objFromDb);
        }
    }
}
