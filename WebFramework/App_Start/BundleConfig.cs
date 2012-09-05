using System.Web;
using System.Web.Optimization;

namespace WebFramework {
    public class BundleConfig {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/boilerplate").Include("~/Scripts/vendor/."));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-2.6.1.min.js"));

            bundles.Add(new StyleBundle("~/Content/main-css").Include(
                "~/Content/css/bootstrap.css",
                "~/Content/css/bootstrap-reponsive.css",
                "~/Content/css/normalize.css",
                "~/Content/css/main.css"));
        }
    }
}