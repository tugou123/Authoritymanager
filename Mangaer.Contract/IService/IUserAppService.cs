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
    }
}
