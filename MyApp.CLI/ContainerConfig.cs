using Autofac;
using MyApp.Autofac;

namespace MyApp.CLI
{
    static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ApplicationDependenciesModule>();
            //Register local dependencies
            builder.RegisterType<MyApplication>().As<IApplication>();

            return builder.Build();
        }
    }
}
