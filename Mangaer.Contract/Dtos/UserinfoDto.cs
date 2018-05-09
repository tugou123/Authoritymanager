using Base.Info.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangaer.Contract.Dtos
{
   public  class UserinfoDto
    {
        public new long Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>   
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
     
        public string Password { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>    
        public string Email { get; set; }
        /// <summary>
        /// 电话
        /// </summary>       
        public string CellPhone { get; set; }
        /// <summary>
        /// QQ
        /// </summary>     
        public string QQ { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>    
        public string Address { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public UserType Type { set; get; }
        /// <summary>
        /// 登陆 次数
        /// </summary>
        public int LoginCount { set; get; }
    }
}
