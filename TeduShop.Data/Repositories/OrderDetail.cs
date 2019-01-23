using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IOrderDetail
    {

    }
    public class OrderDetail : RepositoryBase<OrderDetail>, IOrderDetail
    {
        public OrderDetail(IDbFactory dbFactory)
             : base(dbFactory){

        }
    }
}
