using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherReport.Models
{
    public class WeatherReports
    {
        public Location Location { get; set; }
        public Astronomy Astronomy { get; set; }
    }
    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public DateTime Localtime { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
    public class Astronomy
    {
        public Astro Astro { get; set; }
    }
    public class Astro
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string Moonrise { get; set; }
        public string Moonset { get; set; }
    }
}