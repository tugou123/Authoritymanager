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
    
        public async Task DeleteUserinfo(long userid,long operatorid)
        {
           var _userinfo= DbContext.UserInfos.Where(n => n.Id == userid).FirstOrDefault();
            if (_userinfo == null)
            {
                throw new Exception("tokenInfo instantiated object is empty");
            }
            _userinfo.IsDelete = true;
            _userinfo.OperatorId = operatorid;

            //记录日志
          await  DbContext.SaveChangesAsync();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public async Task<LoginUserDto> Login(string username, string password)
        {
            var _userinfo = DbContext.UserInfos.Where(n => n.UserName == username).FirstOrDefault();
            if (_userinfo == null)
                return new LoginUserDto() { LoginResult = LoginResultEnum.UserNameUnExists };
            if (_userinfo.Password != password)
                return new LoginUserDto() { LoginResult = LoginResultEnum.UserNameOrPasswordError };
            _userinfo.LoginCount += 1;
            var log = new ResultLoginUser()
            {
                Id = 1,
                UserName = _userinfo.UserName
            };

            //异步机制不支持out /ref 参数传递 --解决方案:用Action / Func 委托 逆向传值

            var loginLog = new LoginLog()
            {
                CreateDate = DateTime.Now,
                Dns = "DNS",
                IpAddress = "127.0.0.1",
                Port = 4400,
                Proxyport = 12240,
                UserInfoId = _userinfo.Id

        };
        await DbContext.SaveChangesAsync();
            return new LoginUserDto
            {
                LoginResult = LoginResultEnum.Success,
                ResultloginUser = log
            };
        }

        /// <summary>
        /// 推出 注销 Token 结束时间
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task LogOut(long userid)
        {
            //问题 稍后解决
          var _loginLog =  DbContext.LoginLogs.Where(n => n.UserInfoId== userid).FirstOrDefault();

            if (_loginLog == null)
                throw new Exception("Erro");
            _loginLog.Endtime = DateTime.Now;

           await DbContext.SaveChangesAsync();



        }
        /// <summary>
        /// 编辑User Info 信息
        /// </summary>
        /// <param name="userinfo"></param>
        /// <param name="operatorid"></param>
        /// <returns></returns>
        public async Task UpdataUserInfo(UserInfo userinfo, long operatorid)
        {
           var _user= DbContext.UserInfos.Where(n => n.Id == userinfo.Id).FirstOrDefault();
            if (_user == null)
                throw new Exception("users is invalid");
            _user.Address = userinfo.Address;
            _user.CellPhone = userinfo.CellPhone;
            _user.QQ = userinfo.QQ;
            _user.UserName = userinfo.UserName;
          await  DbContext.SaveChangesAsync();
        }

        /// <summary>
        /// 更新Token  需要重新
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task UpdateToken(long userid)
        {
          var _user=  DbContext.TokenInfos.Where(n => n.UserInfoId == userid).FirstOrDefault();
            if(_user==null)
                throw new Exception("tokeninfos is invalid");
            _user.SingToken =Guid.NewGuid().ToString();//
            _user.ExpiryTime = DateTime.Now.AddMinutes(10);
           await DbContext.SaveChangesAsync();
        }
    }
}
