using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IMenuRepository
    {

    }
    public class MenuRepository : RepositoryBase<MenuRepository>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
