using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IPostRepository
    {

    }
    
    public class PostRepository : RepositoryBase<PostRepository>, IPostRepository
{
        public PostRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
