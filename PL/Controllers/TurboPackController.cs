using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class TurboPackController : Controller
    {
        // GET: TurboPack
        public ActionResult GetUsers()
        {
            return View();
        }
    }
}