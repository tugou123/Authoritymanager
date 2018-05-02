using Manager.Implement;
using Mangaer.Contract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOST
{
    public class CommomHelper
    {
        public static string SoliName
        {
            get
            {
                var name = ConfigurationManager.AppSettings["SoliName"].ToString();
                if (string.IsNullOrWhiteSpace(name))
                {
                    name = "Default";
                }
                return name;
            }
        }

        public static string Filename
        {
            get
            {
                var filename = ConfigurationManager.AppSettings["Filename"].ToString();
                if (string.IsNullOrWhiteSpace(filename))
                {
                    filename = "OrleansConfiguration";
                }
                return filename;
            }
        }

    }

    public class MyStartup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMyTest, MyTest>();
            //services.AddTransient<User.QueryContract.IQuerySeverce.ITestDemo, User.QueryServerce.TestDemo>();

            //var connection = "server=.;uid=sa;pwd=123456;database=codefirst";
            //services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

            #region  注入 需要处理
            //var container = new WindsorContainer();

            //container.Register(Classes.FromThisAssembly().BasedOn<Orleans.Grain>().LifestyleTransient());

            //#endregion

            //foreach (var service in services)
            //{

            //    switch (service.Lifetime)
            //    {
            //        case ServiceLifetime.Singleton:
            //            container.Register(
            //                Component.IsCastleComponent()
            //                    .For(service.ServiceType)
            //                    .ImplementedBy(service.ImplementationType)
            //                    .LifestyleSingleton());
            //            break;
            //        case ServiceLifetime.Transient:
            //            container.Register(
            //                Component
            //                    .For(service.ServiceType)
            //                    .ImplementedBy(service.ImplementationType)
            //                    .LifestyleTransient());
            //            break;
            //        case ServiceLifetime.Scoped:
            //            var error = $"Scoped lifestyle not supported for '{service.ServiceType.Name}'.";
            //            throw new InvalidOperationException(error);
            //    }
            //}
            //return new CastleServiceProvider(container.Kernel);
            #endregion
            return services.BuildServiceProvider();
        }
    }
}
