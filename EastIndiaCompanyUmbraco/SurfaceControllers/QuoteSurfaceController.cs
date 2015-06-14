using EastIndiaCompanyUmbraco.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EastIndiaCompanyUmbraco.SurfaceControllers
{
    public class QuoteSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [HttpPost]
        public ActionResult Index(QuoteModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            TempData.Add("success", "Thank you for your interest, we will contact you with additional information as soon as possible");
            return RedirectToCurrentUmbracoPage();
        }
    }
}