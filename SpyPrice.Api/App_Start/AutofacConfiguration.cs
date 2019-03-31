using Autofac;
using SpyPrice.Data;
using SpyPrice.Infrastracture.AutofacModules;

namespace SpyPrice.Api
{
    public static class AutofacConfiguration
    {
        public static ContainerBuilder GetBuilder()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ApplicationContext>().InstancePerRequest();
            builder.RegisterModule(new MediatrModule());

            return builder;
        }
    }
}
