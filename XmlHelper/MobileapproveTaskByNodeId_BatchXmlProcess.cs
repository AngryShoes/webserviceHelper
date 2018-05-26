using System.Collections.Generic;
using System.Xml;

namespace XmlHelper
{
    public class MobileapproveTaskByNodeId_BatchXmlProcess
    {
        public static Dictionary<string, string> ProcessMobileapproveTaskByNodeId_BatchXml(string xmlString, ref string successInfo)
        {
            Dictionary<string, string> mobileapproveTaskByNodeId_BatchDictionary = new Dictionary<string, string>();
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlString);
            // string xmlText = document.InnerText;
            // document.LoadXml(xmlText);
            successInfo = document.SelectSingleNode("rt").SelectSingleNode("RE").LastChild.InnerText;
            XmlNodeList singleTaskNodeList = document.GetElementsByTagName("RL");
            foreach (XmlNode singleTaskNode in singleTaskNodeList)
            {
                string key = singleTaskNode.Attributes["RID"].Value.ToString();
                if (!mobileapproveTaskByNodeId_BatchDictionary.ContainsKey(key))
                {
                    mobileapproveTaskByNodeId_BatchDictionary.Add(key, singleTaskNode.Attributes["RNA"].Value.ToString());
                }
            }
            return mobileapproveTaskByNodeId_BatchDictionary;
        }
    }
}