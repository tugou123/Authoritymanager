using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model.Model
{
    [Table("Manager_LoginLogs")]
    //==============================================================
    //  作者：三秋  (1932821628@qq.com)
    //  时间：2018/5/5 14:29:11
    //  文件名：LoginLog
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 登陆日志
    //==============================================================
   public class LoginLog:BaseModel
    {
        /// <summary>
        /// 登陆ID
        /// </summary>
        [Key]
       
        public new long Id { set; get; }
        /// <summary>
        /// 登陆主机名称
        /// </summary>
        [Required]
        public string Dns { set; get; }
        /// <summary>
        /// IP 地址
        /// </summary>
        [Required]
        public string IpAddress { set; get; }

        /// <summary>
        /// 端口
        /// </summary>
        public int Port { set; get; }
        /// <summary>
        /// 代理端口
        /// </summary>
        public int Proxyport { set; get; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public  DateTime? Endtime { set; get; }
        /// <summary>
        /// 登陆用户的Id
        /// </summary>
        [Required]
        public  long UserInfoId { set; get; }
    }
}
