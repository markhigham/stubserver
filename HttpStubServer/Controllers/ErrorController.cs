using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HttpStubServer.Controllers
{
    public class ErrorController : ApiController
    {
        [HttpGet, HttpPost, HttpPut, HttpDelete, HttpHead, HttpOptions, AcceptVerbs("PATCH")]
        public HttpResponseMessage Handle404()
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.NotFound);
            responseMessage.ReasonPhrase = "The requested resource is not found you dick";
            return responseMessage;
        }
    }
}