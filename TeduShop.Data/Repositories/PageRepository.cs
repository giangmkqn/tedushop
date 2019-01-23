using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IPageRepository
    {

    }
    public class Pages : RepositoryBase<Pages>, IPageRepository
    {
        public Pages(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
