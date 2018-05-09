using Base.Info.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model.Model
{
    [Table("Manager_Userinfos")]
    //==============================================================
    //  作者：三秋  (***@qq.com)
    //  时间：2018/5/5 14:14:06
    //  文件名：UserInfo
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
    public class UserInfo:BaseModel
    {
       public new  long Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength(100)]
        public string Email { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        [StringLength(100)]
        public string CellPhone { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
        [StringLength(100)]
        public string QQ { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>
        [StringLength(100)]
        public string Address { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public UserType Type { set; get; }
        /// <summary>
        /// 登陆 次数
        /// </summary>
         public int LoginCount { set; get; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public  bool IsActive { set; get; }
        /// <summary>
        /// 是否删除
        /// </summary>
       public bool IsDelete { set; get; }


        public long OperatorId { set; get; }
    }
}
