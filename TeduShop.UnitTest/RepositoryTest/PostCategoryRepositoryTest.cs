using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeduShop.Data.InfraStructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Model;

namespace TeduShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestMethod]
        public void GetAll() {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(2, list.Count());
        }

        [TestMethod]
        public void TestUnit()
        {
            PostCategory category = new PostCategory()
            {
               Name = "Test-Cate",
               Alias = "test-cate",
               Status = true
            };
            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ID);
        }
        
        [TestInitialize]
        public void InitTitalize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
    }
}
