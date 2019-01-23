using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface ISlideRepository
    {

    }
    public class SlideRepository : RepositoryBase<SlideRepository>, SlideRepository
    {
        public SlideRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
