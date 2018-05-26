using System.Collections.Generic;
using System.Xml;

namespace XmlHelper
{
    public class MobileSingleLimitresultXmlProcess
    {
        public static Dictionary<string, string> ProcessMobileSingleLimitresultXml(string xmlString, ref string successInfo)
        {
            Dictionary<string, string> mobileSingleLimitresultDictionary = new Dictionary<string, string>();
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlString);
            // string xmlText = document.InnerText;
            // document.LoadXml(xmlText);
            successInfo = document.SelectSingleNode("rt").SelectSingleNode("RE").LastChild.InnerText;
            XmlNodeList singleTaskNodeList = document.GetElementsByTagName("TARGETINDEX");
            foreach (XmlNode singleTaskNode in singleTaskNodeList)
            {
                string key = singleTaskNode.Attributes["NAME"].Value.ToString();
                if (!mobileSingleLimitresultDictionary.ContainsKey(key))
                {
                    mobileSingleLimitresultDictionary.Add(key, singleTaskNode.Attributes["VALUE"].Value.ToString());
                }
            }
            return mobileSingleLimitresultDictionary;
        }
    }
}