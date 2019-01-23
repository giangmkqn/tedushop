using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IPostTag
    {

    }
    public class PostTag : RepositoryBase<PostTag>, IPostTag
    {
        public PostTag(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
