using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model.Model
{
    [Table("Manager_TokenInfos")]
    //==============================================================
    //  作者：三秋  (***@qq.com)
    //  时间：2018/5/5 14:36:07
    //  文件名：TokenInfo
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
    public class TokenInfo : BaseModel
    {
        public new long Id { set; get; }
        /// <summary>
        /// Token
        /// </summary>
        [Display(Name = "Token")]
      
        public string SingToken { set; get; }
        /// <summary>
        /// 用户Id 
        /// </summary>
        [Display(Name = "用户Id")]
      
        public long UserInfoId { set; get; }
        /// <summary>
        /// 过期时间
        /// </summary>
        [Display(Name = "过期时间")]
       
        public DateTime? ExpiryTime { set; get; }

    }
}
