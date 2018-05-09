using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangaer.Contract.Dtos
{
   public  class TokeninfoDto
    {
        public new long Id { set; get; }
        /// <summary>
        /// Token
        /// </summary>
        public string SingToken { set; get; }
        /// <summary>
        /// 用户Id 
        /// </summary>
        public long UserInfoId { set; get; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpiryTime { set; get; }
    }
}
