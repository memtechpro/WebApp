using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-flatly.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/DashboardAssets/css").Include(
                      "~/DashboardAssets/css/bootstrap-theme.css",
                      "~/DashboardAssets/css/style.css",
                      "~/DashboardAssets/css/bootsrap.min.css",
                      "~/DashboardAssets/css/elegant-icons-style.css",
                      "~/DashboardAssets/css/font-awesome.min.css",                     
                      "~/DashboardAssets/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.css",
                      "~/DashboardAssets/css/owl.carousel.css",
                      "~/DashboardAssets/css/jquery-jvectormap-1.2.2.css",
                      "~/DashboardAssets/css/widgets.css",
                      "~/DashboardAssets/css/style-responsive.css",
                      "~/DashboardAssets/css/jquery-ui-1.10.4.min.css"));

            bundles.Add(new ScriptBundle("~/DashboardAssets/navs").Include(
                      "~/DashboardAssets/js/jquery.js",
                      "~/DashboardAssets/js/jquery-ui-1.10.4.min.js",
                      "~/DashboardAssets/js/jquery-1.8.3.min.js",
                      "~/DashboardAssets/js/jquery-ui-1.9.2.custom.min.js",
                      "~/DashboardAssets/js/bootstrap.min.js",                                         
                      "~/DashboardAssets/js/scripts.js",
                      "~/DashboardAssets/js/jquery.scrollTo.min.js",
                      "~/DashboardAssets/js/jquery.nicescroll.js",
                      "~/DashboardAssets/js/jquery.customSelect.min.js",
                      "~/DashboardAssets/js/jquery.autosize.min.js",
                      "~/DashboardAssets/js/owl.carousel.js"));


        }
    }
}
