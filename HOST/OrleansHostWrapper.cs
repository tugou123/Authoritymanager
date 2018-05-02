using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Orleans.Runtime.Configuration;
using Orleans.Runtime.Host;
namespace HOST
{
    class OrleansHostWrapper : IDisposable
    {



        private SiloHost siloHost;
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool dispose)
        {
            siloHost.Dispose();
            siloHost = null;
        }
        public OrleansHostWrapper(string[] args)
        {
            ParseArguments(args);
            Init();
        }

        public bool ParseArguments(string[] args)
        {
            string deploymentId = null;
            string siloName = Dns.GetHostName();// Default to machine name
            int argPos = 1;
            for (int i = 0; i < args.Length; i++)
            {
                string a = args[i];
                if (a.StartsWith("-") || a.StartsWith("/"))
                {
                    switch (a.ToLowerInvariant())
                    {
                        case "/?":
                        case "/help":
                        case "-?":
                        case "-help":
                            // Query usage help
                            return false;
                        default:
                            Console.WriteLine("Bad command line arguments supplied: " + a);
                            return false;
                    }
                }
                else if (a.Contains("="))
                {
                    string[] split = a.Split('=');
                    if (String.IsNullOrEmpty(split[1]))
                    {
                        Console.WriteLine("Bad command line arguments supplied: " + a);
                        return false;
                    }
                    switch (split[0].ToLowerInvariant())
                    {
                        case "deploymentid":
                            deploymentId = split[1];
                            break;
                        default:
                            Console.WriteLine("Bad command line arguments supplied: " + a);
                            return false;
                    }
                }
                // unqualified arguments below
                else if (argPos == 1)
                {
                    siloName = a;
                    argPos++;
                }
                else
                {
                    // Too many command line arguments
                    Console.WriteLine("Too many command line arguments supplied: " + a);
                    return false;
                }
            }
            var config = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + $"{Path.GetFileNameWithoutExtension(CommomHelper.Filename)}.xml"));
            if (!config.Exists)
            {
                var _config = ClusterConfiguration.LocalhostPrimarySilo();
                _config.UseStartupType<MyStartup>();
                _config.AddMemoryStorageProvider();
                siloHost = new SiloHost(siloName, _config);

            }
            else
            {
                siloHost = new SiloHost(CommomHelper.SoliName, config);

                //  Console.WriteLine($"the {Filename}.xml is ")
            }

            if (deploymentId != null)
                siloHost.DeploymentId = deploymentId;
            return true;

        }
        public void PrintUsage()
        {
            Console.WriteLine(
@"USAGE: 
    OrleansHost.exe [<siloName> [<configFile>]] [DeploymentId=<idString>] [/debug]
Where:
    <siloName>      - Name of this silo in the Config file list (optional)
    DeploymentId=<idString> 
                    - Which deployment group this host instance should run in (optional)
    /debug          - Turn on extra debug output during host startup (optional)");
        }

        /// <summary>
        /// 启动
        /// </summary>
        /// <returns></returns>
        public bool Run
        {
            get
            {
                bool key = false;
                try
                {
                    siloHost.InitializeOrleansSilo();
                    key = siloHost.StartOrleansSilo();
                    if (key)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Successfully started Orleans silo '{siloHost.Name}' as a {siloHost.Type} node.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        throw new SystemException($"Failed to start Orleans silo '{siloHost.Name}' as a {siloHost.Type} node.");
                    }
                }
                catch (Exception exc)
                {

                    siloHost.ReportStartupError(exc);
                    var msg = string.Format("{0}:\n{1}\n{2}", exc.GetType().FullName, exc.Message, exc.StackTrace);
                    Console.WriteLine(msg);
                }
                return key;
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Stop
        {
            get
            {
                bool key = false;
                try
                {
                    siloHost.StopOrleansSilo();

                    Console.WriteLine($"Orleans silo '{siloHost.Name}' shutdown.");
                }
                catch (Exception exc)
                {
                    siloHost.ReportStartupError(exc);
                    var msg = $"{exc.GetType().FullName}:\n{exc.Message}\n{exc.StackTrace}";
                    Console.WriteLine(msg);
                }

                return key;
            }

        }

        /// <summary>
        /// 处理 其他的业务
        /// </summary>
        private void Init()
        {
        }

        public bool Debug
        {
            get { return siloHost != null && siloHost.Debug; }
            set { siloHost.Debug = value; }
        }
    }
}
