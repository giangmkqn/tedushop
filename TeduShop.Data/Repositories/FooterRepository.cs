using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IFooterRepository
    {

    }
    public class FooterRepository : RepositoryBase<FooterRepository>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
