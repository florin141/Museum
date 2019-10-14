using Autofac;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museum.Data;
using Museum.Core.Data;
using Autofac.Core;
using Museum.Core.Domain;
using Museum.Service.Museums;

namespace Museum.ConsoleApp
{
    class Program
    {
        static IContainer Container;

        static void Main(string[] args)
        {
            ConfigureContainer();

            var museumService = Container.Resolve<IMuseumService>();

            var museums = museumService.GetAllMuseums("Zaragoza");

            foreach (var museum in museums)
            {
                Console.WriteLine(museum.Name);
            }
        }

        private static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.Register<DbContext>(ctx => new MuseumObjectContext()).SingleInstance();

            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).SingleInstance();

            builder.RegisterType<MuseumService>().As<IMuseumService>().InstancePerDependency();

            Container = builder.Build();
        }
    }
}
