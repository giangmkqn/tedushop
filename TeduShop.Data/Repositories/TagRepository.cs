using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface ITagRepository
    {

    }
    public class TagRepository : RepositoryBase<TagRepository>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
