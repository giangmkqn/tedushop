using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface ISupportOnline : IRepository<SupportOnline>
    {

    }
    public class SupportOnline : RepositoryBase<SupportOnline>, ISupportOnline
    {
        public SupportOnline(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
