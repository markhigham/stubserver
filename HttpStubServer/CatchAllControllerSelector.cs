using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace HttpStubServer
{
    public class CatchAllControllerSelector : DefaultHttpControllerSelector
    {
        public CatchAllControllerSelector(HttpConfiguration configuration) : base(configuration)
        {
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            var routeValues = request.GetRouteData().Values;
            routeValues["controller"] = "CatchAll";
            routeValues["action"] = "DefaultAction";

            var descriptor = base.SelectController(request);
            return descriptor;
        }
    }
}