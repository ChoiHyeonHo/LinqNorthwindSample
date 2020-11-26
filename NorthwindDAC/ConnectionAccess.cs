using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NorthwindDAC
{
    public abstract class ConnectionAccess
    {
        protected string ConnectionString
        {
            get
            {
                string strConn = string.Empty;
                XmlDocument configXml = new XmlDocument();
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Sample_DEV.xml";

                configXml.Load(path); //파일을 읽어서 메모리에 DOM Tree 구조를 만든다
                XmlNodeList addNodes = configXml.SelectNodes("configuration/settings/add"); 
                // 메모리에 돔 트리 구성이후 configuration/settings/add의 하위 노드를 가져온다. 

                foreach (XmlNode node in addNodes)
                {
                    if (node.Attributes["key"].InnerText == "MyDB") 
                    {
                        strConn = (node.ChildNodes[0]).InnerText;
                        break;
                    }
                }

                return strConn;
            }
        } //xml의 연결 문자열 읽어오기 때문에 읽기전용,  Public일 필요 없으니 Protected
          // 
    }
}
