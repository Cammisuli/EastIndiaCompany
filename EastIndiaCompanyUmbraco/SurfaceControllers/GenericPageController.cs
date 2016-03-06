using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Merchello.Bazaar;
using Merchello.Bazaar.Models.ViewModels;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace EastIndiaCompanyUmbraco.SurfaceControllers
{
    public class GenericModel : MasterModel
    {
        public GenericModel(IPublishedContent content) : base(content) { }
    }

    public class ContactUsController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var viewModel = new GenericModel(model.Content);
            return View(viewModel.ThemeViewPath("generic"), viewModel);
        }
    }

    public class HistoryController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var viewModel = new GenericModel(model.Content);
            return View(viewModel.ThemeViewPath("generic"), viewModel);
        }
    }

    public class Custom404Controller : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var viewModel = new GenericModel(model.Content);
            return View(viewModel.ThemeViewPath("custom404"), viewModel);
        }
    }

    public class AboutUsController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var viewModel = new GenericModel(model.Content);
            return View(viewModel.ThemeViewPath("generic"), viewModel);
        }
    }

    public class VisitUsController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var viewModel = new GenericModel(model.Content);
            return View(viewModel.ThemeViewPath("generic"), viewModel);
        }
    }
}