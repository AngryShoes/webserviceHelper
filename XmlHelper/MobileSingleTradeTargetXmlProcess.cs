using System.Collections.Generic;
using System.Xml;

namespace XmlHelper
{
    public class MobileSingleTradeTargetXmlProcess
    {
        public static Dictionary<string, string> ProcessMobileSingleTradeTargetXml(string xmlString, ref string successInfo)
        {
            Dictionary<string, string> mobileSingleTradeTargetDictionary = new Dictionary<string, string>();
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlString);
            // string xmlText = document.InnerText;
            // document.LoadXml(xmlText);
            successInfo = document.SelectSingleNode("rt").SelectSingleNode("RE").LastChild.InnerText;
            XmlNodeList singleTaskNodeList = document.GetElementsByTagName("TARGETINDEX");
            foreach (XmlNode singleTaskNode in singleTaskNodeList)
            {
                string key = singleTaskNode.Attributes["NAME"].Value.ToString();
                if (!mobileSingleTradeTargetDictionary.ContainsKey(key))
                {
                    mobileSingleTradeTargetDictionary.Add(key, singleTaskNode.Attributes["VALUE"].Value.ToString());
                }
            }
            return mobileSingleTradeTargetDictionary;
        }
    }
}