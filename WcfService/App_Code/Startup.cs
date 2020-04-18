using Autofac;
using Autofac.Integration.Wcf;
using ServicesLibrary;
using ServicesLibrary.Core;

namespace WcfService.App_Code
{
    public class Startup
    {
        public static void AppInitialize()
        {
            var builder = new ContainerBuilder();

            // register Daycare wcf service
            builder.RegisterType<Daycare>();

            // register ExampleService from ServiceLibrary DLL (Standard Library)
            // this service will be injected to Daycare wcf service to costructor
            builder.RegisterType<ExampleService>()
                   .As<IExampleService>();

            AutofacHostFactory.Container = builder.Build();
        }
    }
}