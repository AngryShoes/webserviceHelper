using System.Collections.Generic;
using System.Xml;

namespace XmlHelper
{
    public class MobileSingleTraceLogXmlProcess
    {
        public static Dictionary<string, string> ProcessMobileSingleTraceLogXml(string xmlString, ref string successInfo)
        {
            Dictionary<string, string> mobileSingleTraceLogDictionary = new Dictionary<string, string>();
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlString);
            // string xmlText = document.InnerText;
            // document.LoadXml(xmlText);
            successInfo = document.SelectSingleNode("rt").SelectSingleNode("RE").LastChild.InnerText;
            XmlNodeList singleTaskNodeList = document.GetElementsByTagName("TARGETINDEX");
            foreach (XmlNode singleTaskNode in singleTaskNodeList)
            {
                string key = singleTaskNode.Attributes["NAME"].Value.ToString();
                if (!mobileSingleTraceLogDictionary.ContainsKey(key))
                {
                    mobileSingleTraceLogDictionary.Add(key, singleTaskNode.Attributes["VALUE"].Value.ToString());
                }
            }
            return mobileSingleTraceLogDictionary;
        }
    }
}