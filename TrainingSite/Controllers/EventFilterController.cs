using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace TrainingSite.Controllers
{
    public class EventFilterController : SurfaceController
    {
        [ChildActionOnly]
        public ActionResult FilterForm()
        {
            return PartialView("EventFilterForm");
        }

    }
}