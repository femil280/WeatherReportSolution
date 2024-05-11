using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherReport.Models;

namespace WeatherReport.Services
{
    public interface IAstronomyService
    {
        Task<WeatherReports> RetrieveAstronomyAsync(string city);
    }
}
