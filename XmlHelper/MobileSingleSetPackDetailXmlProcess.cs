using System.Collections.Generic;
using System.Xml;

namespace XmlHelper
{
    public class MobileSingleSetPackDetailXmlProcess
    {
        public static Dictionary<string, string> ProcessMobileSingleSetPackDetailXml(string xmlString, ref string successInfo)
        {
            Dictionary<string, string> mobileSingleTaskNodeDictionary = new Dictionary<string, string>();
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlString);
            // string xmlText = document.InnerText;
            // document.LoadXml(xmlText);
            successInfo = document.SelectSingleNode("rt").SelectSingleNode("RE").LastChild.InnerText;
            XmlNodeList singleTaskNodeList = document.GetElementsByTagName("RL");
            foreach (XmlNode singleTaskNode in singleTaskNodeList)
            {
                string key = singleTaskNode.Attributes["RID"].Value.ToString();
                if (!mobileSingleTaskNodeDictionary.ContainsKey(key))
                {
                    mobileSingleTaskNodeDictionary.Add(key, singleTaskNode.Attributes["RNA"].Value.ToString());
                }
            }
            return mobileSingleTaskNodeDictionary;
        }
    }
}