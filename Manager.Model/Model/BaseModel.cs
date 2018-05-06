using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model.Model
{
    //==============================================================
    //  作者:三秋  (***@qq.com)
    //  时间：2018/5/5 14:14:34
    //  文件名：BaseModel
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：***
    //  修改说明： 
    //==============================================================
   public class BaseModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public object Id { get; set; }

        /// <summary>
        /// 获取图片服务器所在路径
        /// </summary>
        //protected  string ImageServerUrl = ConfigurationManager.AppSettings["ImageServerUrl"];     //TODO:DZY[150811] 暂时不开放此功能
        protected string ImageServerUrl = "";

        public System.DateTime CreateDate { get; set; }
    }
}
