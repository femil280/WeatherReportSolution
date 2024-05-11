using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WeatherReport.Models;

namespace WeatherReport.ViewModel
{
    public class CityViewModel
    {
        public string SelectedCity { get; set; }
        public List<SelectListItem> Cities { get; set; }
        public string Name { get; set; }
        public DateTime Localtime { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string Moonrise { get; set; }
        public string Moonset { get; set;}
    }
}