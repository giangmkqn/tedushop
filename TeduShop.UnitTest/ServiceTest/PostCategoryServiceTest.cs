using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TeduShop.Data.InfraStructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Model;
using TeduShop.Services;


namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);
           var result =  _categoryService.GetAll() as List<PostCategory>;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);

        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory()
            {
                Name = "Test",
                Alias = "test",
                Status = true
            };
            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
            {
                p.ID = 1;
                return p;
            });

        }

        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize() {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {
                    ID = 1,
                    Name = "Dm1",
                    Status = true
                },
                new PostCategory() {
                    ID = 2,
                    Name = "Dm2",
                    Status = true
                },
                new PostCategory() {
                    ID = 3,
                    Name = "Dm2",
                    Status = true

                }
            };
        }
    }
}
