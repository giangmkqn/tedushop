using System;
using System.Collections.Generic;
using TeduShop.Data.InfraStructure;
using TeduShop.Model.Model;
using System.Linq;
namespace TeduShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, PostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory)
             : base(dbFactory){
        }

    } 
}
