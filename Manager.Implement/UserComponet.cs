using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base.Info.Enums;
using Manager.Model.InputeMode;
using Manager.Model.Model;
using Mangaer.Contract.Dtos;
using Mangaer.Contract.IImplement;
using Mangaer.Contract.IService;
using Orleans;
namespace Manager.Implement
{
    public class UserComponet : ComponetBase, IUserComponet
    {
        private IUserAppService _IUserAppService;
        public UserComponet(IUserAppService iUserAppService)
        {
            _IUserAppService = iUserAppService;
        }
        /// <summary>
        /// 创建Token
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task CreataToken(TokenInfo tokenInfo)
        {
            //产生Token
            if (tokenInfo == null)
                throw new Exception("token instantiated object is empty");
            if (tokenInfo.UserInfoId <= 0)
                throw new Exception("uid is invalid ");
            if (string.IsNullOrEmpty(tokenInfo.SingToken))
                throw new Exception("singtoken is invalid ");
            if (tokenInfo.ExpiryTime.HasValue)
                throw new Exception("expirytime is invalid ");
            return await _IUserAppService.CreataToken(tokenInfo);

        }

        public Task<bool> DeleteUserinfo(long userid)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TokeninfoDto>> GetALLTokens()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserinfoDto>> GetAllUserinfo()
        {
            throw new NotImplementedException();
        }

        public Task<TokeninfoDto> GetToken(string token)
        {
            throw new NotImplementedException();
        }

        public Task<TokeninfoDto> GetToken(long userid)
        {
            throw new NotImplementedException();
        }

        public Task<UserinfoDto> GetUserinfo(long userid)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginUserDto> Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(password))
                return new LoginUserDto() { LoginResult = LoginResultEnum.UserNameUnExists };
            return await _IUserAppService.Login(username, password);
        }

        public Task<bool> LogOut(long userid)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdataUserInfo(long userid)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateToken(long userid)
        {
            throw new NotImplementedException();
        }
    }
}
