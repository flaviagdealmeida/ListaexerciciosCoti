using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto1.Presentation.Controllers
{
    public class HomeController : Controller
    {
      
        [Route("/Home/Index")]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Sobre()
        {
            return View();
        }
    }
}