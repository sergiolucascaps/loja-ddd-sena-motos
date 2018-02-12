﻿using System.Web;
using System.Web.Optimization;

namespace SM.UI.Mvc
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

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                        "~/Scripts/ScriptGeral.js",
                        "~/Scripts/toastr.js"));

            bundles.Add(new StyleBundle("~/bundles/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.custom.css",
                      "~/Content/site.css",
                      "~/Content/toastr.css"));

            // Bundles de Paginas por Controller 
            bundles.Add(new ScriptBundle("~/bundles/Content/Usuarios/js").Include(
                "~/Scripts/PorController/Usuarios.js"
                ));

            // Bundles de Paginas Individuais

            bundles.Add(new ScriptBundle("~/bundles/Content/UsuariosCreate/js").Include("~/Scripts/PorPage/Usuarios_Create.js"));
            bundles.Add(new ScriptBundle("~/bundles/Content/UsuariosEdit/js").Include("~/Scripts/PorPage/Usuarios_Edit.js"));
        }
    }
}
