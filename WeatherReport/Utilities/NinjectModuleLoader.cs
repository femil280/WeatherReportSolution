using IoC;
using Ninject.Modules;
using WeatherReport.Services;
using WeatherReport.Services.ServiceRepository;


namespace WeatherReport.Utilities
{
    public class NinjectModuleLoader: NinjectModule
    {
        public override void Load()
        {
            // Bind your dependencies here
            Bind<IInformationSevice>().To<GetWeatherInformationPerCountry>();
            Bind<IWeatherService>().To<WeatherServiceRepository>();
            Bind<IAstronomyService>().To<AstronomyServiceRepository>();
        }
    }
}