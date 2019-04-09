using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace SerquestCMS.Controllers
{
    public class SharedLayoutController : SurfaceController
    {
        // GET: SharedLayout
        public ActionResult Header()
        {
            //List<NavigationList> nav = GetNavigation();
            return PartialView("~/Views/Partials/SharedLayout/Header.cshtml");
        }

        public ActionResult Footer()
        {
            return PartialView("~/Views/Partials/SharedLayout/Footer.cshtml");
        }
    }
}