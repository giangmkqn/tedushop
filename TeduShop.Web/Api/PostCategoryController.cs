using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Model;
using TeduShop.Services;
using TeduShop.Web.InfraStructure.Core;
using TeduShop.Web.InfraStructure.Extentions;
using TeduShop.Web.Models;

namespace TeduShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) :
            base(errorService)
            {
            this._postCategoryService = postCategoryService;
            }
        // GET api/<controller>

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request) {
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _postCategoryService.GetAll();
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listCategory);
                return response;
            });
        }

        [Route("post")]
        public HttpResponseMessage Post(HttpRequestMessage request, PostCategoryViewModel postCategoryVm) {
           
                return CreateHttpResponse(request, () =>
                {
                    HttpResponseMessage respone = null;
                    if (ModelState.IsValid)
                    {
                        request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                    }
                    else {
                        PostCategory newPostCategory = new PostCategory();
                        newPostCategory.UpdatePostCategory(postCategoryVm);
                         
                        _postCategoryService.Add(newPostCategory);
                        _postCategoryService.SaveChanges();

                    }
                    return respone = request.CreateResponse(HttpStatusCode.Created, "Succes");
                });
        }

        [Route("Put")]
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategoryViewModel postCategoryVm)
        {

            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage respone = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadGateway, ModelState);
                }
                else {
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID);
                    postCategoryDb.UpdatePostCategory(postCategoryVm);

                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.SaveChanges();

                    respone = request.CreateResponse(HttpStatusCode.OK);
                }

                return respone;
            });
        }
    }
}