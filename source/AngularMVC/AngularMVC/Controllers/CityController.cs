using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularMVC.BBL;

namespace AngularMVC.Controllers
{
    public class CityController : Controller
    {
        private readonly CityManager _cityM = new CityManager();
        // GET: City
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoadCities()
        {
            var data = _cityM.LoadCities();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}