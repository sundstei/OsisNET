using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Autofac;
using Autofac.Integration.Mvc;
using Osis.Models.ViewModels;
using Osis.Services;

namespace Osis
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.CreateMap<LogonSummary, DashboardDisplayViewModel>();

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<LogonInfoService>().As<ILogonInfoService>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}