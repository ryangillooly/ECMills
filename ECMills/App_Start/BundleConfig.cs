using System.Web;
using System.Web.Optimization;

namespace ECMills
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;   //enable CDN support

            bundles.Add(new StyleBundle("~/MainCSS").Include(
                "~/Assets/css/*.min.css",
                "~/Assets/css/MyCSS/Layout.css",
                "~/Assets/css/fresh-bootstrap-table.css"
            ));

            bundles.Add(new ScriptBundle("~/CoreJS").Include(
                "~/Assets/js/core/jquery.min.js",
                "~/Assets/js/core/popper.min.js",
                "~/Assets/js/core/bootstrap-material-design.min.js"
            ));

         
            bundles.Add(new ScriptBundle("~/MaterialJS").Include(
                "~/Assets/js/plugins/perfect-scrollbar.jquery.min.js",
                "~/Assets/js/plugins/moment.min.js",
                "~/Assets/js/plugins/sweetalert2.js",
                "~/Assets/js/plugins/jquery.validate.min.js",
                "~/Assets/js/plugins/jquery.bootstrap-wizard.js",
                "~/Assets/js/plugins/bootstrap-selectpicker.js",
                "~/Assets/js/plugins/bootstrap-datetimepicker.min.js",
                "~/Assets/js/plugins/jquery.datatables.min.js",
                "~/Assets/js/plugins/bootstrap-tagsinput.js",
                "~/Assets/js/plugins/jasny-bootstrap.min.js",
                "~/Assets/js/plugins/fullcalendar.min.js",
                "~/Assets/js/plugins/jquery-jvectormap.js",
                "~/Assets/js/plugins/nouislider.min.js",
                "~/Assets/js/plugins/arrive.min.js",
                "~/Assets/js/plugins/chartist.min.js",
                "~/Assets/js/plugins/bootstrap-notify.js",
                "~/Assets/js/material-dashboard.js" ,
                "~/Assets/js/demo.js",
                "~/Assets/js/bootstrap-table.js"
            ));

            BundleTable.EnableOptimizations = true;

        }
    }
}
