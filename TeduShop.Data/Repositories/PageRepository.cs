using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {

    }
    public class Pages : RepositoryBase<Page>, IPageRepository
    {
        public Pages(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
