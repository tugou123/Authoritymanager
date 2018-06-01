using System;
using System.Threading.Tasks;
using Base.Expand;
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

            var token = DESEncrypt.Encrypt(string.Format("{0}{1}", Guid.NewGuid().ToString("D"), DateTime.Now.Ticks));

            token = token.Substring(11, 31);
            var TX= Guid.NewGuid().ToString("D").Substring(0, 10);
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
            var tol0 = await user.Login("test", "test");

            if (tol0.LoginResult == Base.Info.Enums.LoginResultEnum.Success)
            {



                user.CreataToken(new Manager.Model.Model.TokenInfo() { ExpiryTime = DateTime.Now.AddMinutes(2), SingToken = token, UserInfoId = tol0.ResultloginUser.Id }).Wait();
            }
         
        }
    }


}
