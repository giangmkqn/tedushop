using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Model;
using TeduShop.Services;

namespace TeduShop.Web.InfraStructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;
        public ApiControllerBase(IErrorService errorService) {
            this._errorService = errorService;
        }

        protected HttpResponseMessage CreateResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> func) {
            HttpResponseMessage respone = null;
            try
            {
                respone = func.Invoke();

            }
            catch (DbUpdateException dbEx) {
                LogError(dbEx);
                respone = requestMessage.CreateErrorResponse(HttpStatusCode.BadGateway, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                respone = requestMessage.CreateErrorResponse(HttpStatusCode.BadGateway, ex.Message);
            }
            return respone;
        }
        private void LogError(Exception ex) {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch {

            }
        }
    }
}
