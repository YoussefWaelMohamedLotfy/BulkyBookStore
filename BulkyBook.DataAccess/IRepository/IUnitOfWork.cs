namespace BulkyBook.DataAccess.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }

        void Save();
    }
}
