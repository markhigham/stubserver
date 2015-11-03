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

            var routeValues = Request.GetRouteData().Values;
            var controller = routeValues["controller"] ;
            var action = routeValues["action"];

            var message = string.Format("Catch all DefaultAction Controller {0} Action {1}", controller, action);

            responseMessage.ReasonPhrase = message;


            return responseMessage;
        }

        [HttpGet, HttpPost, HttpPut, HttpDelete, HttpHead, HttpOptions, AcceptVerbs("PATCH")]
        public HttpResponseMessage ErrorAction()
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            responseMessage.ReasonPhrase = "This is the error in catch all controller";
            return responseMessage;
        }
    }
}