using System.Web.Http;

namespace MagazinesDemo.AppWithMiniSPAs
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
            );

            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
