using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasteFood.Controllers
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            string PageName = "Menü";
            TempData["Page"] = PageName;
            return View();
        }

      
    }
}