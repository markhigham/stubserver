using System.Web.Http;
using System.Web.Http.Dispatcher;
using Owin;

namespace HttpStubServer
{
    internal class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "Error404",
            //    routeTemplate: "{*url}",
            //    defaults: new { controller = "CatchAll", action = "DefaultAction" }
            //);

            config.Services.Replace(typeof(IHttpControllerSelector), new CatchAllControllerSelector(config));

            appBuilder.UseWebApi(config);
        }
    }
}