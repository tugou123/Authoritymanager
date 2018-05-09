using Manager.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Manager.DoXMl
{
    public class WriteXML
    {
        public static void WriteToXML(List<TokenInfo> token)
        {
            XmlDocument xmldoc;
            XmlNode xmlnode;
            XmlElement xmlelem;

            xmldoc = new XmlDocument();
            //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>  
            XmlDeclaration xmldecl;
            xmldecl = xmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
            xmldoc.AppendChild(xmldecl);
         
            //加入一个根元素  
            xmlelem = xmldoc.CreateElement("", "Tokens", "");
            xmldoc.AppendChild(xmlelem);
            //加入另外一个元素  
            foreach (var item in token)
            {

                XmlNode root = xmldoc.SelectSingleNode("Token");//查找<Employees>   
                XmlElement xe1 = xmldoc.CreateElement("Node");//创建一个<Node>节点   
                xe1.SetAttribute("Id", "1");//设置该节点genre属性   
            
                XmlElement xesub1 = xmldoc.CreateElement("SingToken");
                xesub1.InnerText = item.SingToken;//设置文本节点   
                xe1.AppendChild(xesub1);//添加到<Node>节点中   


                XmlElement xesub2 = xmldoc.CreateElement("UserInfoId");
                xesub2.InnerText = item.UserInfoId.ToString();
                xe1.AppendChild(xesub2);

                XmlElement xesub3 = xmldoc.CreateElement("ExpiryTime");
                xesub3.InnerText = item.ExpiryTime.ToString();
                xe1.AppendChild(xesub3);
                root.AppendChild(xe1);//添加到<Employees>节点中   
            }
            xmldoc.Save("c:/data.xml");
            //保存创建好的XML文档  

        }

    }
}
