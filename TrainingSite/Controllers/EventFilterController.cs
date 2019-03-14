using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace TrainingSite.Controllers
{
    public class EventFilterController : SurfaceController
    {
        [ChildActionOnly]
        public ActionResult FilterForm()
        {
            var m = new Models.EventFilterModel
            {
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(30)
                
            };
            return PartialView("EventFilterForm", m);
        }

        [HttpPost]
        public ActionResult FilterEvents (Models.EventFilterModel model)
        {


            var filteredResults = CurrentPage.Children.Where(x => x.GetPropertyValue<DateTime>("eventDate") >= model.StartDate.Date && x.GetPropertyValue<DateTime>("eventDate") <= model.EndDate.Date);
            TempData["filteredEvents"] = filteredResults;
            return RedirectToCurrentUmbracoPage();

            
        }

    }
}