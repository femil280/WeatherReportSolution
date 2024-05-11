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
    public class WeatherServiceRepository : IWeatherService
    {
        private readonly HttpClient _HttpClient;

        public WeatherServiceRepository(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task<WeatherReports> RetrieveWeatherAsync(string city)
        {
            var apiKey = "6b24bd0214mshd015cb8b7d427cap1a45f2jsn5fa2a0a67801";
            var encodedCity = Uri.EscapeDataString(city);
            var apiUrl = $"https://weatherapi-com.p.rapidapi.com/current.json?q={city}";

            _HttpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", apiKey);

            var response = await _HttpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherReports>(content);
                return weatherData;
            }

            return null;
        }
    }
}