using System.Web;
using System.Web.Optimization;

namespace Basic.Client
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
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/realty_expert_jquery").Include(
                        "~/Scripts/realty_expert/jquery-2.2.3.min.js",
                        "~/Scripts/realty_expert/jquery.flexslider.js",
                        "~/Scripts/realty_expert/modernizr.js",
                        "~/Scripts/realty_expert/menu.js",
                        "~/Scripts/realty_expert/jquery.filterizr.js",
                        "~/Scripts/realty_expert/controls.js",
                        "~/Scripts/realty_expert/jquery.swipebox.min.js",
                        "~/Scripts/realty_expert/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/realty_expert_css").Include(
                      "~/Content/realty_expert/*.css"));
        }
    }
}
