using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherReport.Models;
using WeatherReport.ViewModel;

namespace WeatherReport.Services
{
    public interface IInformationSevice
    {
        Task<CityViewModel> GetAllWeatherInformationAsync(string city);
    }
}
