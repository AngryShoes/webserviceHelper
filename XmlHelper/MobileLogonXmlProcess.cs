using System.Collections.Generic;
using System.Xml;

namespace XmlHelper
{
    public class MobileLogonXmlProcess
    {
        /// <summary>
        /// 处理用户登录的xml
        /// </summary>
        /// <param name="xmlString">调用webservice返回的xml</param>
        /// <param name="logonSuccessInfo">获取xml中的【<RC>0</RC>】节点，0表示登录成功，其他值表示登录失败</param>
        /// <returns>返回审批类型的List</returns>
        public static List<string> ProcessMobileLogonXml(string xmlString, ref string logonSuccessInfo)
        {
            List<string> targetTypeList = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            string innerText = doc.InnerText;
            doc.LoadXml(doc.InnerText);
            XmlNode nodes = doc.SelectSingleNode("rt").SelectSingleNode("RE").SelectSingleNode("RC");
            logonSuccessInfo = nodes.FirstChild.Value.ToString();

            XmlNodeList nodeList = doc.GetElementsByTagName("M");
            foreach (XmlNode node in nodeList)
            {
                targetTypeList.Add(node.Attributes["C"].Value.ToString());
            }
            return targetTypeList;
            //XmlNode rootNode = doc.SelectSingleNode("rt");
            //XmlNodeList xmlNodeList = rootNode.ChildNodes;
            //foreach (XmlNode node in xmlNodeList)
            //{
            //    XmlNode rc = node.SelectSingleNode("RC");
            //}
        }
    }
}