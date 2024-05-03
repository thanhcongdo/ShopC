namespace ShopC.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopCDbContext dbContext;

        public ShopCDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopCDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}