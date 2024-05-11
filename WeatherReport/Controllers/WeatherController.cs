using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WeatherReport.Services;
using WeatherReport.ViewModel;

namespace WeatherReport.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IInformationSevice _Service;
       
        public WeatherController(IInformationSevice service)
        {
            _Service = service;
        }
        // GET: Weather
        public ActionResult Index()
        {
            var model = new CityViewModel
            {
                Cities = new List<SelectListItem>
                {
                     new SelectListItem { Value = "Dublin", Text = "Dublin" },
                     new SelectListItem { Value = "Cork", Text = "Cork" },
                     new SelectListItem { Value = "Belfast", Text = "Belfast" }
                }
            };
            return View(model);
        }
        [HttpPost]
        public async Task <ActionResult> GetWeather(CityViewModel cityviewmodel)
        {
            var repo = await _Service.GetAllWeatherInformationAsync(cityviewmodel.SelectedCity);
            //return RedirectToAction("Index",repo);
            return View(repo);
        }
    }
}
