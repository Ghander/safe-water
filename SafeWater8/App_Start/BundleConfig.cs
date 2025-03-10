﻿using System.Web;
using System.Web.Optimization;

namespace SafeWater8 {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/StyleSheet1.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/angular-resource.js",
                      "~/Scripts/angular-animate.js",
                      "~/Scripts/angular-ui/ui-bootstrap-tpls.js"));


            bundles.Add(new ScriptBundle("~/bundles/angularCustom")
                .IncludeDirectory("~/Scripts/ngApp", "*.js", true));

            //bundles.Add(new ScriptBundle("~/bundles/angularCustom").Include(
            //    "~/Scripts/ngApp/app.js",
            //    "~/Scripts/ngApp/templateController.js",//put here because below service relies on service part of the controller
            //    "~/Scripts/ngApp/loginService.js",
            //    "~/Scripts/ngApp/ctmntService.js",
            //    "~/Scripts/ngApp/loginController.js",
            //    "~/Scripts/ngApp/ctmntListController.js",
            //    "~/Scripts/ngApp/createListController.js",
            //    "~/Scripts/ngApp/registerController.js"
            //    ));
        }
    }
}
