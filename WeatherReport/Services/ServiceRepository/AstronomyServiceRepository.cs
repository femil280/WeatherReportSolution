using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using WeatherReport.Models;

namespace WeatherReport.Services.ServiceRepository
{
    public class AstronomyServiceRepository:IAstronomyService
    {
        private readonly HttpClient _HttpClient;

        public AstronomyServiceRepository(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task<WeatherReports> RetrieveAstronomyAsync(string city)
        {
            var apiKey = "6b24bd0214mshd015cb8b7d427cap1a45f2jsn5fa2a0a67801";
            var apiUrl = $"https://weatherapi-com.p.rapidapi.com/astronomy.json?q={city}";

            _HttpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", apiKey);

            var response = await _HttpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var AstroData = JsonConvert.DeserializeObject<WeatherReports>(content);
                return AstroData;
            }

            return null;
        }
    }
}