using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace SerquestCMS.Controllers
{
    public class BlogsController : SurfaceController
    {
        // GET: Blogs
        public ActionResult BlogInfo()
        {
            return PartialView("~/Views/Partials/Blogs/BlogInfo.cshtml", CurrentPage);
        }

        public ActionResult BlogsOverview()
        {
            var blogList = CurrentPage.DescendantsOrSelf().Where(x => x.IsDocumentType("blogPage"));

            return PartialView("~/Views/Partials/Blogs/BlogsOverview.cshtml", blogList);
        }
    }
}