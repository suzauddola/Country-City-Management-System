using System.Web;
using System.Web.Optimization;

namespace AngularMVC
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
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/style.css"));

            // angular bundle

            //bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
            //            "~/Scripts/Render/angular.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
            //            "~/Scripts/Render/angular.min.js",
            //            "~/Scripts/Render/angular.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
            //            "~/Scripts/Render/angular.min.js",
            //            "~/Scripts/Render/angular.min.js",
            //            "~/Scripts/Render/angular-resource.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/othersangular").Include(
            //            "~/Scripts/App/App.js"));

            //bundles.Add(new ScriptBundle("~/bundles/othersangular").Include(
            //           "~/Scripts/App/App.js",
            //           "~/Scripts/App/Controller.js"));

            //bundles.Add(new ScriptBundle("~/bundles/othersangular").Include(
            //           "~/Scripts/App/App.js",
            //           "~/Scripts/App/Controller.js",
            //           "~/Scripts/App/directives.js"));

            //bundles.Add(new ScriptBundle("~/bundles/othersangular").Include(
            //           "~/Scripts/App/App.js",
            //           "~/Scripts/App/Controller.js",
            //           "~/Scripts/App/directives.js",
            //           "~/Scripts/App/filters.js"));

        }
    }
}
