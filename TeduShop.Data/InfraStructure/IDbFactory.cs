using System;

namespace TeduShop.Data.InfraStructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}
