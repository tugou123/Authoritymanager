using Base.Info.Enums;

using Manager.Model.InputeMode;
using Manager.Model.Model;
using Mangaer.Contract.Dtos;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangaer.Contract.IImplement
{
  public interface IUserComponet: IGrainWithStringKey
    {
        #region 登陆
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<LoginUserDto> Login(string username, string password);
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task LogOut(long userid);
        /// <summary>
        /// 创建Token
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task CreataToken(TokenInfo tokenInf);

        /// <summary>
        /// 更新Token
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task UpdateToken(long userid);
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        Task<TokeninfoDto> GetToken(string token);
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        Task<TokeninfoDto> GetToken(long userid);
        /// <summary>
        /// 获取所有的Tokens
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TokeninfoDto>> GetALLTokens();

        #endregion


        #region 用户信息
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task<UserinfoDto> GetUserinfo(long userid);
        /// <summary>
        /// 获取所有的用户信息
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UserinfoDto>> GetAllUserinfo();

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <returns></returns>
        Task UpdataUserInfo(UserinfoDto userinfo);
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task DeleteUserinfo(long userid,long operatorid);

        #endregion


    }
}
