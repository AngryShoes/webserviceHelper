using System.Collections.Generic;
using System.Xml;

namespace XmlHelper
{
    public class MobileGetTaskNodeGroupXmlProcess
    {
        /// <summary>
        /// 处理查询审批数据分组信息的xml
        /// </summary>
        /// <param name="xmlString">调用webservice返回的xml</param>
        /// <param name="successInfo">获取xml中的【<RM>查询成功</RM>】节点</param>
        /// <returns>返回组合编号</returns>
        public static List<string> ProcessMobileGetTaskNodeGroupXml(string xmlString, ref string successInfo)
        {
            List<string> groupNumberList = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            string innerText = doc.InnerText;
            doc.LoadXml(doc.InnerText);
            successInfo = doc.SelectSingleNode("rt").SelectSingleNode("RE").LastChild.InnerText;
            XmlNodeList xmlNodeList = doc.GetElementsByTagName("G");
            foreach (XmlNode node in xmlNodeList)
            {
                groupNumberList.Add(node.Attributes["C"].ToString());
            }
            return groupNumberList;
        }
    }
}