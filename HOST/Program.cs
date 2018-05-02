using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOST
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain  appDomain= AppDomain.CreateDomain("HostSilo", null, new AppDomainSetup() {
                AppDomainInitializer = StartUp,
                AppDomainInitializerArguments = args
            });
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Orleans Silo is running.\nPress Enter to terminate...");
            Console.ReadLine();
            appDomain.DoCallBack(ShutDowmSilo);
        }

        static void StartUp(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);
            if (!hostWrapper.Run)
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }
        }

        static void ShutDowmSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }
        private static OrleansHostWrapper hostWrapper;
    }
}
