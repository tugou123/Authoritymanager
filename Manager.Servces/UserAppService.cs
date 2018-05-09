using Base.EntityFramework;
using Base.Info.Enums;
using Manager.Model.Model;
using Mangaer.Contract.Dtos;
using Mangaer.Contract.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Manager.Servces
{
    public class UserAppService : IUserAppService
    {
        Entity DbContext;
        public UserAppService()
        {
            DbContext = new Entity();
        }
        /// <summary>
        /// 写入数据数据库
        /// </summary>
        /// <param name="tokenInfo"></param>
        /// <returns></returns>
        public async Task CreataToken(TokenInfo tokenInfo)
        {
            tokenInfo.CreateDate = DateTime.Now;
            DbContext.TokenInfos.Add(tokenInfo);
            await DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<LoginUserDto> Login(string username, string password)
        {
          var _userinfo=  DbContext.UserInfos.Where(n => n.UserName == username).FirstOrDefault();
            if (_userinfo == null)
                return new LoginUserDto() { LoginResult = LoginResultEnum.UserNameUnExists };
            if (_userinfo.Password!= password)
                return new LoginUserDto() { LoginResult = LoginResultEnum.UserNameOrPasswordError };
             _userinfo.LoginCount += 1;
            var log = new ResultLoginUser()
            {
                Id = 1,
                UserName = _userinfo.UserName
            };
            await DbContext.SaveChangesAsync();
            //异步机制不支持out /ref 参数传递 --解决方案:用Action / Func 委托 逆向传值
            return new LoginUserDto
            {
                LoginResult = LoginResultEnum.Success,
                ResultloginUser = log
            };
        }
    }
}
