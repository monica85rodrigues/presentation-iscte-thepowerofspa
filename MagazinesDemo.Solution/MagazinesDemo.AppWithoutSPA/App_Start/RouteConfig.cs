using System.Web.Mvc;
using System.Web.Routing;

namespace MagazinesDemo.AppWithoutSPA
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: MagazineRoute,
                url: "magazines",
                defaults: new { controller = "Magazine", action = "Index" }
            );

            routes.MapRoute(
                name: MagazinesByYearRoute,
                url: "magazines-year",
                defaults: new { controller = "Magazine", action = "GetMagazinesByYear", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: CreateMagazineRoute,
                url: "create-magazine",
                defaults: new { controller = "Magazine", action = "Create", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Magazine", action = "Index", id = UrlParameter.Optional }
            );

        }

        public const string MagazineRoute = "magazines";
        public const string MagazinesByYearRoute = "magazines-year";
        public const string CreateMagazineRoute = "create-magazine";

    }
}
