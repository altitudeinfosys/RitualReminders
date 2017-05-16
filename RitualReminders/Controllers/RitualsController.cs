using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RitualReminders.Controllers
{
    public class RitualsController : Controller
    {
        // GET: Rituals
        public ActionResult Index()
        {
            return View();
        }
    }
}