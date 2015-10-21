using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HttpStubServer.Controllers
{
    public class CatchAllController : ApiController
    {
        [HttpGet, HttpPost, HttpPut, HttpDelete, HttpHead, HttpOptions, AcceptVerbs("PATCH")]
        public HttpResponseMessage DefaultAction()
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            responseMessage.ReasonPhrase = "This is the catch all controller";
            return responseMessage;
        }
    }
}