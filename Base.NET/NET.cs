using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Base.NET
{
    public class NET
    {
     
      
        /// <summary>
        /// 获取主机名称
        /// </summary>
        public static string GetHostName
        {
            get
            {
                return Dns.GetHostName();
            }
        }

        /// <summary>
        /// 获取IP
        /// </summary>
        public static string IP
        {
            get
            {
                try
                {
                    IPHostEntry IpEntry = Dns.GetHostEntry(GetHostName);
                    foreach(var item in IpEntry.AddressList)
                    {
                        if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                           
                            return item.ToString();
                        }
                    }
                    return "";

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }


        /// <summary>
        /// 获取端口号
        /// </summary>
        public static int Proint { set; get; } = 8980;

        /// <summary>
        /// 代理端口号
        /// </summary>
        public static int Proxyport { set; get; } = 12240;
    }
}
