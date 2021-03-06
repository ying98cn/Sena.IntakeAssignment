﻿using System.Web.Optimization;

namespace Sena.IntakeAssignment
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

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/angular.js",
                "~/Scripts/ngDialog.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjsApp")
                .IncludeDirectory("~/Scripts/app/module", "*.js")
                .IncludeDirectory("~/Scripts/app/services", "*.js")
                .IncludeDirectory("~/Scripts/app/controllers", "*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/ngDialog.css",
                "~/Content/ngDialog-theme-default.css"));

            bundles.Add(new StyleBundle("~/bundles/customCss").Include(
                "~/Content/app/app.css"));
        }
    }
}