using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<OrderDetail>
    {

    }
    public class OrderRepository : RepositoryBase<OrderDetail>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
