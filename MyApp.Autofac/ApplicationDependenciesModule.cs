using Autofac;

namespace MyApp.Autofac
{
    public class ApplicationDependenciesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<Infrastructure.MyService>().As<Core.Interfaces.IService>();
            builder.RegisterType<Infrastructure.ConsoleWriter>().As<Core.Interfaces.IWriter>();
        }
    }
}
