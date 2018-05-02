using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model.InputeMode
{
    //==============================================================
    //  作者：***  (***@qq.com)
    //  时间：2018/4/26 20:12:27
    //  文件名：LoginUser
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
    public class LoginUser
    {
        public int Id { set; get; }
        public string UserName { set; get; }

        public string Password { set; get; }

        public string UserType { set; get; }

        public bool RemenberMe { set; get; }

        public string Brower { set; get; }
        public int UId { set; get; }

        public bool? IsSaler { set; get; }
    }
}
