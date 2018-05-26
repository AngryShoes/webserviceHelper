using Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using XmlHelper;

namespace IRFixIncomeSystemApprovement
{
    public partial class MobileSingleLimitresultForm : Form
    {
        private string successInfo = string.Empty;
        private readonly string _url = ConfigurationManager.AppSettings[CN.URL].ToString();

        public string TaskId
        {
            get { return cbb_taskid.SelectedItem.ToString(); }
        }

        public MobileSingleLimitresultForm()
        {
            InitializeComponent();
        }

        private void btn_mobileSingleLimitresult_Click(object sender, EventArgs e)
        {
            //获取报文
            //string xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileSingleLimitresult", GetSingleLimitresultMethod());

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
            var singleLimitresultDictionary = MobileSingleLimitresultXmlProcess.ProcessMobileSingleLimitresultXml(xmlString, ref successInfo);
            if (successInfo == "查询成功")
            {
                MessageBox.Show(successInfo);
            }
            //显示查询数据
            foreach (var keyValuePair in singleLimitresultDictionary)
            {
                lbx_singleLimitresult.Items.Add(keyValuePair.Key + " " + keyValuePair.Value);
            }
        }

        private void MobileSingleLimitresultForm_Load(object sender, EventArgs e)
        {
            tbx_usercode.Text = ((MobileGetTaskNodeLstByPageForm)this.Owner).UserCode;
            List<string> taskIdList = ((MobileGetTaskNodeLstByPageForm)this.Owner).TaskIdList;
            cbb_taskid.DataSource = taskIdList;
        }

        private Hashtable GetSingleLimitresultMethod()
        {
            Hashtable hashTable = new Hashtable();
            string userCode = tbx_usercode.Text.Trim();
            string taskId = TaskId;
            string isIncludeConfirmed = tbx_isIncludeConfirmed.Text.Trim();
            string isIncludeOrdered = tbx_isIncludeOrdered.Text.Trim();
            hashTable.Add("aUserCode", userCode);
            hashTable.Add("aTaskId", taskId);
            hashTable.Add("aIsIncludeConfirmed", isIncludeConfirmed);
            hashTable.Add("aIsIncludeOrdered", isIncludeOrdered);
            return hashTable;
        }
    }
}