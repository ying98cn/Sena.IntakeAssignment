using Autofac;
using Autofac.Integration.Mvc;
using Sena.IntakeAssignment.Data.Interface;
using Sena.IntakeAssignment.Data.Repository;
using System.Web.Mvc;

namespace Sena.IntakeAssignment.IoC
{
    /// <summary>
    /// The Autofac configuration
    /// </summary>
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<RecordRepository>().As<IRecordRepository>().SingleInstance().PreserveExistingDefaults();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}