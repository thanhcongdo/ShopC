namespace ShopC.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}