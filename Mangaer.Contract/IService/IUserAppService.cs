using Manager.Model.Model;
using Mangaer.Contract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangaer.Contract.IService
{
    public interface  IUserAppService:IDisposable
    {
       
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<LoginUserDto> Login(string username, string password);
        /// <summary>
        /// 写入 Token
        /// </summary>
        /// <param name="tokenInfo"></param>
        /// <returns></returns>
        Task CreataToken(TokenInfo tokenInfo);
       /// <summary>
       /// 删除用户信息
       /// </summary>
       /// <param name="userid"></param>
       /// <returns></returns>
        Task DeleteUserinfo(long userid, long operatorid);
       /// <summary>
       /// 退出
       /// </summary>
       /// <param name="userid"></param>
       /// <returns></returns>
        Task LogOut(long userid);
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task UpdataUserInfo(UserInfo userinfo, long operatorid);
        /// <summary>
        /// 更新Token
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task UpdateToken(long userid);
    }


}
