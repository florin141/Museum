using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Museum.Api.Infrastructure;
using Museum.Core.Data;
using Museum.Data;
using Museum.Service.Cities;
using Museum.Service.Countries;
using Museum.Service.Features;
using Museum.Service.Museums;
using Museum.Service.MuseumTypes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Museum.Api
{
    public class AutofacConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // REGISTER DEPENDENCIES
            // Register your Web API controllers.
            // You can register controllers all at once using assembly scanning...
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // ...or you can register individual controlllers manually.
            builder.Register<DbContext>(ctx => new MuseumObjectContext()).SingleInstance();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).SingleInstance();

            builder.RegisterType<CityService>().As<ICityService>().InstancePerRequest();
            builder.RegisterType<CountryService>().As<ICountryService>().InstancePerRequest();
            builder.RegisterType<FeatureService>().As<IFeatureService>().InstancePerRequest();
            builder.RegisterType<MuseumService>().As<IMuseumService>().InstancePerRequest();
            builder.RegisterType<MuseumTypeService>().As<IMuseumTypeService>().InstancePerRequest();

            // Register mapping profile with all the different mappings the we're going to need so 
            // that we can use them with dependency injection.

            #region Option1

            //var autoMapperProfileTypes = AppDomain.CurrentDomain.GetAssemblies()
            //    .SelectMany(a => a.GetTypes()
            //    .Where(p => typeof(Profile)
            //    .IsAssignableFrom(p) && p.IsPublic && !p.IsAbstract));

            //var autoMapperProfiles = autoMapperProfileTypes.Select(p => (Profile)Activator.CreateInstance(p));

            //builder.Register(ctx => new MapperConfiguration(cfg =>
            //{
            //    foreach (var profile in autoMapperProfiles)
            //    {
            //        cfg.AddProfile(profile);
            //    }
            //}));

            //builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().PropertiesAutowired();

            #endregion

            #region Option2

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            builder.RegisterInstance(mapperConfig.CreateMapper())
                .As<IMapper>()
                .SingleInstance();

            #endregion

            // OPTIONAL: Register the Autofac filter provider.
            //builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            // builder.RegisterWebApiModelBinderProvider();

            // BUILD THE CONTAINER
            // Set the dependency resolver to be Autofac.
            var container = builder.Build();

            // Replace the MVC Dependency Resolver with Autofac
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}