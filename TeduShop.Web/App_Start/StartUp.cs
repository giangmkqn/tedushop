using System;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Owin;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using TeduShop.Data.InfraStructure;
using TeduShop.Data;
using TeduShop.Data.Repositories;
using TeduShop.Services;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Web.Http;
using Autofac.Integration.WebApi;
 
[assembly: OwinStartup(typeof(TeduShop.Web.App_Start.StartUp))]

namespace TeduShop.Web.App_Start
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
        }
        public void ConfigAutofac(IAppBuilder app) {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<TeduShopDbContext>().AsSelf().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}
