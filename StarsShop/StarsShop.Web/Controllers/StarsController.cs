using Microsoft.AspNetCore.Mvc;
using StarsShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarsShop.Web.Controllers
{
    public class StarsController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MyStarList = new List<Star>()
              {
                new Star(){Name= "Véga", Magnitude=0.03m, Type="A0Va",},
                new Star(){Name= "Sirius", Magnitude=-1.47m, Type="A1V",},
                new Star(){Name= "Conapus", Magnitude=-0.72m, Type="F0Ib",},
                new Star(){Name= "Alsephina", Magnitude=2.03m, Type="AIV",}
              };

            return View();

        }
    }
}
