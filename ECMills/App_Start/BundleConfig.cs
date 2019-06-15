using System.Web;
using System.Web.Optimization;

namespace ECMills
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Assets/js/jquery.validate*",
                        "~/Assets/js/jquery.unobtrusive-ajax.js",
                        "~/Assets/js/jquery.unobtrusive-ajax.min.js",
                        "~/Assets/js/jquery.validate.unobtrusive.js",
                        "~/Assets/js/jquery.validate.unobtrusive.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Assets/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Assets/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Assets/css/bootstrap.css",
                      "~/Assets/css/site.css",
                      "~/Assets/css//material-dashboard.css?v=2.1.1",
                      "~/url/https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons",
                      "~/url/https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/Fonts").Include(
                    "~/url/https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons",
                    "~/url/https://use.fontawesome.com/releases/v5.8.1/css/all.css"));
        }
    }
}
