using Mangaer.Contract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangaer.Contract.IService.IQuery
{
   public interface  IUserAppServiceQuery
    {
        /// <summary>
        /// 获取所有Token
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TokeninfoDto>> GetALLTokens(long operatorid);
        /// <summary>
        /// 获取所有的用户信息
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UserinfoDto>> GetAllUserinfo(long operatorid);
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<TokeninfoDto> GetToken(string token);
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task<TokeninfoDto> GetToken(long userid);
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task<UserinfoDto> GetUserinfo(long userid, long operatorid);
    }
}
