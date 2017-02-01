using AngularMVC.BBL;
using AngularMVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace AngularMVC.Controllers
{
    public class CountryController : Controller
    {
        private readonly CountryManager _countryManager = new CountryManager(); 

        // GET: Country
        public ActionResult Index()
        {
            //List<Countries> countryList = countryManager.LoadCountries();
            //return View(countryList);
            return View();
        }

        public JsonResult LoadCountries()
        {
            var data = _countryManager.LoadCountries();
            return  Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}