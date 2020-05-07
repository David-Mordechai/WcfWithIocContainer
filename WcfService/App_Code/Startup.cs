using Autofac;
using Autofac.Integration.Wcf;
using AutoMapper;
using DataLibrary;
using DataLibrary.Core;
using DataLibrary.Core.Services;
using DataLibrary.Services;
using ServicesLibrary;
using ServicesLibrary.Core;
using System.Web.Configuration;
using WcfService.Mapping;

namespace WcfService.App_Code
{
    public class Startup
    {
        public static void AppInitialize()
        {
            var builder = new ContainerBuilder();

            // register Daycare wcf service
            builder.RegisterType<Daycare>();

            var webApiConnectionString = WebConfigurationManager.ConnectionStrings["webApiConnectionString"].ConnectionString;

            builder.RegisterType<DataBaseConfiguration>()
                .WithParameter("connectionString", webApiConnectionString)
                .As<IDataBaseConfiguration>();

            builder
                .RegisterType<DataLibraryDbContext>()
                .AsSelf()
                .InstancePerDependency();

            // register ExampleService from ServiceLibrary DLL (Standard Library)
            // this service will be injected to Daycare wcf service to costructor
            builder.RegisterType<ExampleService>()
                   .As<IExampleService>();

            builder.RegisterType<ExampleDataService>()
                   .As<IExampleDataService>();

            // register AutoMapper 
            builder.RegisterInstance(CreateMapper()).As<IMapper>();

            AutofacHostFactory.Container = builder.Build();
        }

        private static Mapper CreateMapper()
        {
            var mapperConfiguration =
                            new MapperConfiguration(cfg =>
                            {
                                cfg.AddProfile<CityMapper>();
                                cfg.AddProfile<GetCitiesResultMapper>();
                            });
            return new Mapper(mapperConfiguration);
        }
    }
}