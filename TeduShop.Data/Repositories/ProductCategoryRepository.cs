using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;
namespace TeduShop.Data.Repositories
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>
    {
        public interface IProductCategoryRepository {
            IEnumerable<ProductCategory> GetByAlias(string Alias);
        }
        public ProductCategoryRepository(DbFactory dbFactory)
            : base(dbFactory) {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias) {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
