using Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using WebServiceProcessor;
using XmlHelper;

namespace IRFixIncomeSystemApprovement
{
    public partial class MobileGetTaskNodeGroupForm : Form
    {
        private readonly string _url = ConfigurationManager.AppSettings[CN.URL].ToString();
        private List<string> taskNodeGroupList = null;

        public List<string> TaskNodeGroupList
        {
            get { return taskNodeGroupList; }
            set { taskNodeGroupList = value; }
        }

        public string UserCode
        {
            get { return ((Logon)this.Owner).UserCode; }
        }

        public string TargetType
        {
            get { return cbb_targetType.SelectedItem.ToString(); }
        }

        public string BeginDate
        {
            get { return tbx_begin_date.Text; }
        }

        public string EndDate
        {
            get { return tbx_end_date.Text; }
        }

        public string DataType
        {
            get { return tbx_data_type.Text; }
        }

        public MobileGetTaskNodeGroupForm()
        {
            InitializeComponent();
            AcceptButton = btn_mobile_get_task_node_group;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_mobile_get_task_node_group_Click(object sender, EventArgs e)
        {
            string suceessInfo = string.Empty;
            var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeGroup", GetTaskNodeGroupMethod());
            taskNodeGroupList = MobileGetTaskNodeGroupXmlProcess.ProcessMobileGetTaskNodeGroupXml(xmlString, ref suceessInfo);
            if (suceessInfo == "查询成功")
            {
                if (MessageBox.Show(suceessInfo) == DialogResult.OK)
                {
                    MobileGetTaskNodeLstByPageForm mobileGetTaskNodeLstByPageForm = new MobileGetTaskNodeLstByPageForm();
                    mobileGetTaskNodeLstByPageForm.Owner = this;
                    mobileGetTaskNodeLstByPageForm.Show();
                    this.Visible = false;
                }
            }
        }

        private void MobileGetTaskNodeGroupForm_Load(object sender, EventArgs e)
        {
            List<string> targetTypeList = ((Logon)this.Owner).TargetTypes;
            cbb_targetType.DataSource = targetTypeList;
            tbx_usercode.Text = ((Logon)this.Owner).UserCode;
        }

        private Hashtable GetTaskNodeGroupMethod()
        {
            Hashtable hashTable = new Hashtable();
            string userCode = UserCode;
            string targetType = string.Empty;

            switch (TargetType)
            {
                case "中台预审":
                    targetType = "PREOTCTRADE";
                    break;

                case "交易审批":
                    targetType = "OTCTRADE";
                    break;

                case "清算审批":
                    targetType = "INST_SET_AUDIT";
                    break;

                case "财务审批":
                    targetType = "INST_ACC_AUDIT";
                    break;

                default:
                    break;
            }
            string benginDate = BeginDate;
            string endDate = EndDate;
            string dataType = DataType;
            hashTable.Add("aTargetType", targetType);
            hashTable.Add("aUserCode", userCode);
            hashTable.Add("aBeg_date", benginDate);
            hashTable.Add("aEnd_date", endDate);
            hashTable.Add("aDataType", dataType);

            return hashTable;
        }
    }
}