using System.Web.Optimization;

namespace MagazinesDemo.AppWithMiniSPAs
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts/external").Include(
                        "~/Content/scripts/external/jquery-1.10.2.js",
                        "~/Content/scripts/external/bootstrap.js",
                        "~/Content/scripts/external/knockout-2.3.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts/app").Include(
                      "~/Content/scripts/app/app.*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts/app/authors").Include(
                      "~/Content/scripts/app/authors/app-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts/app/magazines").Include(
                      "~/Content/scripts/app/magazines/app-*"));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
                      "~/Content/styles/bootstrap.css",
                      "~/Content/styles/site.css"));
        }
    }
}
