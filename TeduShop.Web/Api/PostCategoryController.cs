using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Services;
using TeduShop.Web.InfraStructure.Core;

namespace TeduShop.Web.Api
{
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;


        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) :
            base(errorService)
            {
            this._postCategoryService = postCategoryService;
            }
        // GET api/<controller>
    }
}