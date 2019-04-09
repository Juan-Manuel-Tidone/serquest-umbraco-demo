using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace SerquestCMS.Controllers
{
    public class BasicComponentsController : SurfaceController
    {
        public ActionResult Banner()
        {
            return PartialView("~/Views/Partials/Basic Components/Banner.cshtml", CurrentPage);
        }

        public ActionResult TitleAndContent()
        {
            //IPublishedContent should be pass a the Model
            return PartialView("~/Views/Partials/Basic Components/TitleAndContent.cshtml", CurrentPage);
        }

        public ActionResult ExploreRendering()
        {
            var list = CurrentPage.DescendantsOrSelf().Where(x => x.IsDocumentType("exploreRendering"));

            return PartialView("~/Views/Partials/Basic Components/ExploreRendering.cshtml", list);
        }

        public ActionResult ImageAndContent()
        {
            var list = CurrentPage.DescendantsOrSelf().Where(x => x.IsDocumentType("imageAndContent"));

            return PartialView("~/Views/Partials/Basic Components/ImageAndContent.cshtml", list);
        }

        public ActionResult Video()
        {
            //IPublishedContent should be pass a the Model
            return PartialView("~/Views/Partials/Basic Components/Video.cshtml", CurrentPage);
        }

        public ActionResult Quotes()
        {
            return PartialView("~/Views/Partials/Basic Components/Quotes.cshtml", CurrentPage);
        }
    }
}