﻿using Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using XmlHelper;

namespace IRFixIncomeSystemApprovement
{
    public partial class MobileSingleTradeDetailForm : Form
    {
        private string successInfo = string.Empty;
        private readonly string _url = ConfigurationManager.AppSettings[CN.URL].ToString();

        public string Id
        {
            get { return cbb_sysOrdId.SelectedItem.ToString(); }
        }

        public MobileSingleTradeDetailForm()
        {
            InitializeComponent();
        }

        private void btn_mobileSingleTradeDetail_Click(object sender, EventArgs e)
        {
            // 获取报文
            //string xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileSingleTaskNodeTree", GetSingleTradeDetailMethod());

            // 测试报文
            string xmlString = @"<rt>
 <RE>
  <RC>0</RC>
  <RM>查询成功</RM>
 </RE>
  <RL RID=""282662"" RNA=""资金主管"" />
  <RL RID=""307637"" RNA=""崔总"" />
  <RL RID=""307638"" RNA=""侯总"" />
  <RL RID=""282661"" RNA=""自营主管"" />
  <RL RID=""315888"" RNA=""销售主管"" />
  <RL RID=""327314"" RNA=""分管领导"" />
  <RL RID=""626542"" RNA=""Admin"" />
  <RL RID=""996643"" RNA=""财务经理"" />
  <RL RID=""1115966"" RNA=""曹如巧测试"" />
</rt>";
            // 处理报文
            var singleTaskNodeTreeDictionary = MobileSingleTradeDetailFormXmlProcess.ProcessMobileSingleTradeDetailXml(xmlString, ref successInfo);
            if (successInfo == "查询成功")
            {
                MessageBox.Show(successInfo);
            }
            // 显示查询数据
            foreach (var keyValuePair in singleTaskNodeTreeDictionary)
            {
                lbx_singleTradeDetail.Items.Add(keyValuePair.Key + " " + keyValuePair.Value);
            }
        }

        private void MobileSingleTradeDetailForm_Load(object sender, EventArgs e)
        {
            tbx_usercode.Text = ((MobileGetTaskNodeLstByPageForm)this.Owner).UserCode;
            List<string> IdList = ((MobileGetTaskNodeLstByPageForm)this.Owner).IdList;
            cbb_sysOrdId.DataSource = IdList;
        }

        private Hashtable GetSingleTradeDetailMethod()
        {
            Hashtable hashTable = new Hashtable();
            string userCode = tbx_usercode.Text.Trim();
            string instId = Id;
            hashTable.Add("aUserCode", userCode);
            hashTable.Add("aSysOrdId", Id);

            return hashTable;
        }
    }
}