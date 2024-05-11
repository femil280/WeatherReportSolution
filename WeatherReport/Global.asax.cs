using Ninject.Modules;
using Ninject.Web.Mvc;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WeatherReport.Utilities;

namespace WeatherReport
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Register Ninject modules
            var modules = new INinjectModule[]
            {
            new NinjectModuleLoader()
            };
            var kernel = new StandardKernel(modules);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
