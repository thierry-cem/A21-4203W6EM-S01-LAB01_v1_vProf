using Microsoft.AspNetCore.Mvc;
using StarsShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarsShop.Web.Controllers
{
    public class StarTypesController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MyStarTypeList = new List<StarType>()
                  {
                    new StarType(){TypeName= "O", Id=1},
                    new StarType(){TypeName= "F", Id=2}
                    //https://fr.wikipedia.org/wiki/Type_spectral#Tableau_r%C3%A9capitulatif

                  };


            return View();
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(StarType model)
        {

            if (ModelState.IsValid) return RedirectToAction(nameof(Index));
            else return View();
        
        }


    }
}
