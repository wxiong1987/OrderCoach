using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderCoach.Web.Areas.Public.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Public/Company
        public ActionResult Index()
        {
            return View();
        }
    }
}