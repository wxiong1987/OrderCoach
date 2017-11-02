using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderCoach.Web.Areas.Authenticated.Controllers
{
    public class OrderController : Controller
    {
        // GET: Authenticated/Order
        public ActionResult Index()
        {
            return View();
        }
    }
}