using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderCoach.Web.Areas.Authenticated.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Authenticated/Statistics
        public ActionResult Index()
        {
            return View();
        }
    }
}