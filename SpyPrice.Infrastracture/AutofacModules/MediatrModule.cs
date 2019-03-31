using Autofac;
using MediatR;
using System;
using Module = Autofac.Module;

namespace SpyPrice.Infrastracture.AutofacModules
{
    public class MediatrModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            builder.RegisterAssemblyTypes(assemblies).AsClosedTypesOf(typeof(IRequest<>)).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(assemblies).AsClosedTypesOf(typeof(IRequestHandler<>)).AsImplementedInterfaces().PropertiesAutowired();
            builder.RegisterAssemblyTypes(assemblies).AsClosedTypesOf(typeof(IRequestHandler<,>)).AsImplementedInterfaces().PropertiesAutowired();
            builder.RegisterAssemblyTypes(assemblies).AsClosedTypesOf(typeof(IPipelineBehavior<,>)).AsImplementedInterfaces().PropertiesAutowired();
            builder.RegisterAssemblyTypes(assemblies).AsClosedTypesOf(typeof(AsyncRequestHandler<>)).AsImplementedInterfaces().PropertiesAutowired();
            builder.RegisterAssemblyTypes(assemblies).AsClosedTypesOf(typeof(INotificationHandler<>)).AsImplementedInterfaces();

            builder
                .RegisterType<Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(ctx =>
            {
                var c = ctx.Resolve<IComponentContext>();
                return t => c.ResolveOptional(t);
            });
        }
    }
}
