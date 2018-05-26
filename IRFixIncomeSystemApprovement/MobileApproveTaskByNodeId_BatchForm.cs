using Constants;
using System;
using System.Collections;
using System.Configuration;
using System.Windows.Forms;
using XmlHelper;

namespace IRFixIncomeSystemApprovement
{
    public partial class MobileApproveTaskByNodeId_BatchForm : Form
    {
        private string successInfo = string.Empty;
        private readonly string _url = ConfigurationManager.AppSettings[CN.URL].ToString();

        public MobileApproveTaskByNodeId_BatchForm()
        {
            InitializeComponent();
        }

        private void btn_approveTaskByNodeId_Batch_Click(object sender, EventArgs e)
        {
            // 获取报文
            //string xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileApproveTaskByNodeId_Batch", GetApproveTaskByNodeId_BatchMethod());

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
            var singleTaskNodeTreeDictionary = MobileapproveTaskByNodeId_BatchXmlProcess.ProcessMobileapproveTaskByNodeId_BatchXml(xmlString, ref successInfo);
            if (successInfo == "查询成功")
            {
                MessageBox.Show(successInfo);
            }
            // 显示查询数据
            foreach (var keyValuePair in singleTaskNodeTreeDictionary)
            {
                lbx_mobileApproveTaskByNodeId_Batch.Items.Add(keyValuePair.Key + " " + keyValuePair.Value);
            }
        }

        private Hashtable GetApproveTaskByNodeId_BatchMethod()
        {
            Hashtable hashTable = new Hashtable();
            string userCode = tbx_usercode.Text.Trim();
            string targetType = tbx_targetType.Text.Trim();
            string nodeIds = tbx_nodeIds.Text.Trim();
            string action = tbx_action.Text.Trim();
            string actionNote = tbx_actionNote.Text.Trim();
            string dataType = tbx_data_type.Text.Trim();
            string target = string.Empty;
            switch (targetType)
            {
                case "中台预审":
                    target = "PREOTCTRADE";
                    break;

                case "交易审批":
                    target = "OTCTRADE";
                    break;

                case "清算审批":
                    target = "INST_SET_AUDIT";
                    break;

                case "财务审批":
                    target = "INST_ACC_AUDIT";
                    break;

                default:
                    break;
            }
            hashTable.Add("actionUser", userCode);
            hashTable.Add("targetType", target);
            hashTable.Add("aNodeIds", nodeIds);
            hashTable.Add("aAction", action);
            hashTable.Add("actionNote", actionNote);
            hashTable.Add("aDataTypeCurrent", dataType);
            return hashTable;
        }

        private void MobileApproveTaskByNodeId_BatchForm_Load(object sender, EventArgs e)
        {
            string nodeIds = string.Join(",", ((MobileGetTaskNodeLstByPageForm)this.Owner).NodeIdList.ToArray());
            tbx_nodeIds.Text = nodeIds;
            tbx_usercode.Text = ((MobileGetTaskNodeLstByPageForm)this.Owner).UserCode;
            string targetType = ((MobileGetTaskNodeLstByPageForm)this.Owner).TargetType;

            tbx_targetType.Text = targetType;
            tbx_data_type.Text = ((MobileGetTaskNodeLstByPageForm)this.Owner).DataType;
        }
    }
}