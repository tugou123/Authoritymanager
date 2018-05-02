using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model.InputeMode
{
    //==============================================================
    //  作者：***  (***@qq.com)
    //  时间：2018/4/26 20:30:19
    //  文件名：Log
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
   public class Log
    {

        public string Action { set; get; }
        public string Detail { set; get; }
        public DateTime CreateDate { set; get; }

        public string CreatorLoginName { set; get; }

        public string IpAddress { set; get; }

        public string HostName { set; get; }

        public int Id { set; get; }

        public DateTime EndTime { set; get; }

      

        public int UserId { set; get; }
        

      
    }
}
