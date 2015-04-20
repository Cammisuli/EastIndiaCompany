using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace EastIndiaCompanyUmbraco.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/sitecss")
                .Include("~/App_Plugins/Merchello.Bazaar/Themes/EastIndiaCompany/Assets/css/bootstrap.css")
                .Include("~/App_Plugins/Merchello.Bazaar/Themes/EastIndiaCompany/Assets/css/styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/sitejs")
                .Include("~/App_Plugins/Merchello.Bazaar/Themes/EastIndiaCompany/Assets/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/corejs")
                .Include("~/App_Plugins/Merchello.Bazaar/Assets/js/jquery.unobtrusive-ajax.min.js")
                .Include("~/App_Plugins/Merchello.Bazaar/Assets/js/jquery.validate.unobtrusive.min.js")
                .Include("~/App_Plugins/Merchello.Bazaar/Assets/js/jquery.validate.min.js")
                .Include("~/App_Plugins/Merchello.Bazaar/Assets/js/merchello.bazaar.js"));
        }
    }
}