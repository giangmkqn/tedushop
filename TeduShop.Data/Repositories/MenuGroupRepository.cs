using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IMenuGroupRepository
    {

    }
    public class MenuGroupRepository : RepositoryBase<MenuGroupRepository>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
