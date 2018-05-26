using Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using XmlHelper;

namespace IRFixIncomeSystemApprovement
{
    public partial class MobileSingleTraceLogForm : Form
    {
        private string successInfo = string.Empty;
        private readonly string _url = ConfigurationManager.AppSettings[CN.URL].ToString();

        public string TaskId
        {
            get { return cbb_taskid.SelectedItem.ToString(); }
        }

        public MobileSingleTraceLogForm()
        {
            InitializeComponent();
        }

        private void MobileSingleTraceLogForm_Load(object sender, EventArgs e)
        {
            tbx_usercode.Text = ((MobileGetTaskNodeLstByPageForm)this.Owner).UserCode;
            List<string> taskIdList = ((MobileGetTaskNodeLstByPageForm)this.Owner).TaskIdList;
            cbb_taskid.DataSource = taskIdList;
        }

        private void btn_mobileSingleTaskNodeTree_Click(object sender, EventArgs e)
        {
            //获取报文
            //string xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileSingleTraceLog", GetSingleTraceLogMethod());

            //测试报文
            string xmlString = @"<rt>
 <RE>
  <RC>0</RC>
  <RM>查询成功</RM>
 </RE>
  <TARGETINDEX NAME=""资金收付差/盈亏"" VALUE=""-1,001,136.61"" />
  <TARGETINDEX NAME=""资金收付差/盈亏(组合)"" VALUE=""-1,001,136.61"" />
  <TARGETINDEX NAME=""占资费用"" VALUE=""3,401.12"" />
  <TARGETINDEX NAME=""占资费用(组合)"" VALUE=""3,401.12"" />
  <TARGETINDEX NAME=""最终资金收付差/盈亏"" VALUE=""-1,001,136.61"" />
  <TARGETINDEX NAME=""最终资金收付差/盈亏(组合)"" VALUE=""-1,001,136.61"" />
  <TARGETINDEX NAME=""券敞口"" VALUE=""13中信银行债：100万元"" />
  <TARGETINDEX NAME=""券敞口(组合)"" VALUE=""13中信银行债：100万元"" />
  <TARGETINDEX NAME=""交易费用"" VALUE=""412.50"" />
  <TARGETINDEX NAME=""交易费用(组合)"" VALUE=""412.50"" />
</rt>";
            //处理报文
            var singleTraceLogDictionary = MobileSingleTraceLogXmlProcess.ProcessMobileSingleTraceLogXml(xmlString, ref successInfo);
            if (successInfo == "查询成功")
            {
                MessageBox.Show(successInfo);
            }
            //显示查询数据
            foreach (var keyValuePair in singleTraceLogDictionary)
            {
                lbx_singleTraceLog.Items.Add(keyValuePair.Key + " " + keyValuePair.Value);
            }
            //////////
        }

        private Hashtable GetSingleTraceLogMethod()
        {
            Hashtable hashTable = new Hashtable();
            string userCode = tbx_usercode.Text.Trim();
            string taskId = TaskId;
            hashTable.Add("aUserCode", userCode);
            hashTable.Add("aTaskId", taskId);

            return hashTable;
        }
    }
}