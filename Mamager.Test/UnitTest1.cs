using System;
using System.Threading.Tasks;
using Manager.Model.InputeMode;
using Mangaer.Contract;
using Mangaer.Contract.IImplement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orleans;
using Orleans.Runtime.Configuration;

namespace Mamager.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var config = ClientConfiguration.LocalhostSilo();

            GrainClient.Initialize(config);
           var userService = GrainClient.GrainFactory.GetGrain<ITest>("key");
            //var response = await userService.GetTicksFromService() ;
             // var response = await userService.Login("123", "123");
            var tol = await userService.Holle();
            var tolp = await userService.GetName();

            IUserComponet user = GrainClient.GrainFactory.GetGrain<IUserComponet>("ke");
            //var response = await userService.GetTicksFromService() ;
            //  var response = await userService.Login("123", "123");
            LoginUser loginUser=null;
            var tol0 = await user.Login("123", "123");
          //  var tx = await user.Login("", "", (i) => i = loginUser);
          //  Console.WriteLine("\n\n{0}\n\n", tol0);
        }
    }


}
