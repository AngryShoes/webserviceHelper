using Models;
using System.Collections.Generic;
using System.Xml;

namespace XmlHelper
{
    public class MobileGetTaskNodeLstByPageXmlProcess
    {
        public static List<TradeTaskNodeDetailModel> ProcessMobileGetTaskNodeLstByPageXml(string xmlString, ref string successInfo)
        {
            var tradeTaskNodeList = new List<TradeTaskNodeDetailModel>();
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlString);
            // string xmlText = document.InnerText;
            // document.LoadXml(xmlText);
            successInfo = document.SelectSingleNode("rt").SelectSingleNode("RE").LastChild.InnerText;
            XmlNodeList taskIdNodeList = document.GetElementsByTagName("G");
            foreach (XmlNode node in taskIdNodeList)
            {
                string tidKey = node.Attributes["TID"].Value.ToString();//把节点中的TID作为Key

                tradeTaskNodeList.Add(
                        new TradeTaskNodeDetailModel()
                        {
                            TID = node.Attributes["TID"].Value.ToString(),
                            NID = node.Attributes["NID"].Value.ToString(),
                            ID = node.Attributes["ID"].Value.ToString(),
                            ISN = node.Attributes["ISN"].Value.ToString(),
                            TR = node.Attributes["TR"].Value.ToString(),
                            TY = node.Attributes["TY"].Value.ToString(),
                            IC = node.Attributes["IC"].Value.ToString(),
                            IN = node.Attributes["IN"].Value.ToString(),
                            IGRADE = node.Attributes["IGRADE"].Value.ToString(),
                            BG = node.Attributes["BG"].Value.ToString(),
                            SD = node.Attributes["SD"].Value.ToString(),
                            CO = node.Attributes["CO"].Value.ToString(),
                            OD = node.Attributes["OD"].Value.ToString(),
                            PR = node.Attributes["PR"].Value.ToString(),
                            ESN = node.Attributes["ESN"].Value.ToString(),
                            HM = node.Attributes["HM"].Value.ToString(),
                            OA = node.Attributes["OA"].Value.ToString(),
                            ORP = node.Attributes["ORP"].Value.ToString(),
                            LRATE = node.Attributes["LRATE"].Value.ToString(),
                            EVALNO = node.Attributes["EVALNO"].Value.ToString(),
                            GR = node.Attributes["GR"].Value.ToString()
                        });
            }
            //返回的dictionary 在后面四个查询模块中用到，返回查询信息。。。
            return tradeTaskNodeList;
        }
    }
}