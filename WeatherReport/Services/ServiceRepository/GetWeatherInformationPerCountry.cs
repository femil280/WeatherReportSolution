using IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WeatherReport.Models;
using WeatherReport.ViewModel;

namespace WeatherReport.Services.ServiceRepository
{
    public class GetWeatherInformationPerCountry : IInformationSevice
    {
        private readonly IWeatherService _WeatherService;
        private readonly IAstronomyService _AstronomyService;

        public GetWeatherInformationPerCountry(IWeatherService weatherService, IAstronomyService astronomyService)
        {
            _WeatherService = weatherService;
            _AstronomyService = astronomyService;
        }

        public async Task<CityViewModel> GetAllWeatherInformationAsync(string city)
        {
            var weatherTask = await _WeatherService.RetrieveWeatherAsync(city);
            var astronomyTask = await _AstronomyService.RetrieveAstronomyAsync(city);


            if (weatherTask != null  && astronomyTask != null)
            {

                return new CityViewModel
                {
                   Name = weatherTask.Location.Name,
                   Localtime = weatherTask.Location.Localtime,
                   Country = weatherTask.Location.Country,
                   Region = weatherTask.Location.Region,
                   Sunrise = astronomyTask.Astronomy.Astro.Sunrise,
                   Sunset = astronomyTask.Astronomy.Astro.Sunset,
                   Moonrise = astronomyTask.Astronomy.Astro.Moonrise,
                   Moonset = astronomyTask.Astronomy.Astro.Moonset
                };
            }

            return null;
        }
    }
}