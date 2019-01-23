using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository
    {

    }
    public class OrderRepository : RepositoryBase<OrderRepository>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
