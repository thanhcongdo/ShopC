using System;

namespace ShopC.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopCDbContext Init();
    }
}