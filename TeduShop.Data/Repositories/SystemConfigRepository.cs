using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface ISystemConfigRepository
    {

    }
    public class SystemConfigRepository : RepositoryBase<SystemConfigRepository>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
