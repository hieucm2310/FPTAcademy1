using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NWEB.Practice.HieuCM3.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("name") != "admin")
            {
                return RedirectToAction("Login", "Home", new { area = "" });
            }
            return View();
        }
    }
}
