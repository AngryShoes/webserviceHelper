using Constants;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using XmlHelper;

namespace IRFixIncomeSystemApprovement
{
    public partial class MobileGetTaskNodeLstByPageForm : Form
    {
        private string successInfo = string.Empty;
        private string _dataType = string.Empty;
        private string _url = ConfigurationManager.AppSettings[CN.URL].ToString();
        private List<string> _taskIdList = null;
        private List<string> _instIdList = null;
        private List<string> _idList = null;
        private List<string> _nodeIdList = null;

        public List<string> TaskIdList
        {
            get { return _taskIdList; }
            set { _taskIdList = value; }
        }

        public List<string> InstIdList
        {
            get { return _instIdList; }
            set { _instIdList = value; }
        }

        public List<string> IdList
        {
            get { return _idList; }
            set { _idList = value; }
        }

        public List<string> NodeIdList
        {
            get { return _nodeIdList; }
            set { _nodeIdList = value; }
        }

        public string TaskNodeGroupCode
        {
            get { return cbb_tasknodegroup.SelectedItem.ToString(); }
        }

        public string UserCode
        {
            get { return tbx_usercode.Text.Trim(); }
        }

        public string DataType
        {
            get { return tbx_data_type.Text.Trim(); }
        }

        public string TargetType
        {
            get { return tbx_targetType.Text; }
        }

        public string PageNumber
        {
            get { return tbx_pagenumber.Text.Trim(); }
            set { tbx_pagenumber.Text = value; }
        }

        public MobileGetTaskNodeLstByPageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeLstByPage", GetTaskNodeLstByPageMethod());
            string xmlstr = @"<rt>
  <RE>
    <RC>0</RC>
    <RM>查询成功</RM>
  </RE>
  <G TID=""4049995"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049998"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049999"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049990"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
</rt>";
            var mobileGetTaskNodeLstByPageList = MobileGetTaskNodeLstByPageXmlProcess.ProcessMobileGetTaskNodeLstByPageXml(xmlstr, ref successInfo);
            BindingSource bindSource = new BindingSource();
            bindSource.DataSource = mobileGetTaskNodeLstByPageList;
            dataGridView1.DataSource = bindSource;
            dataGridView1.Columns["TID"].HeaderText = "审批作业编号";
            dataGridView1.Columns["NID"].HeaderText = "审批节点编号";
            dataGridView1.Columns["ID"].HeaderText = "交易编号";
            dataGridView1.Columns["ISN"].HeaderText = "内部证券账户名称";
            dataGridView1.Columns["TR"].HeaderText = "交易员";
            dataGridView1.Columns["TY"].HeaderText = "交易方向";
            dataGridView1.Columns["IC"].HeaderText = "债券代码";
            dataGridView1.Columns["IN"].HeaderText = "债券名称";
            dataGridView1.Columns["IGRADE"].HeaderText = "主体评级";
            dataGridView1.Columns["BG"].HeaderText = "BG";
            dataGridView1.Columns["SD"].HeaderText = "清算速度";
            dataGridView1.Columns["CO"].HeaderText = "CO";
            dataGridView1.Columns["OD"].HeaderText = "交易日期 ";
            dataGridView1.Columns["PR"].HeaderText = "交易对手";
            dataGridView1.Columns["ESN"].HeaderText = "外部证券账户名称";
            dataGridView1.Columns["HM"].HeaderText = "托管场所";
            dataGridView1.Columns["OA"].HeaderText = "交易金额";
            dataGridView1.Columns["ORP"].HeaderText = "交易全价 ";
            dataGridView1.Columns["LRATE"].HeaderText = "借贷/拆借/回购利率";
            dataGridView1.Columns["EVALNO"].HeaderText = "中债估值偏移度";
            dataGridView1.Columns["GR"].HeaderText = "GR";
        }

        private void MobileGetTaskNodeLstByPageForm_Load(object sender, EventArgs e)
        {
            List<string> taskNodeGroupList = ((MobileGetTaskNodeGroupForm)this.Owner).TaskNodeGroupList;
            cbb_tasknodegroup.DataSource = taskNodeGroupList;
            tbx_usercode.Text = ((MobileGetTaskNodeGroupForm)this.Owner).UserCode;
            tbx_targetType.Text = ((MobileGetTaskNodeGroupForm)this.Owner).TargetType;
            tbx_begin_date.Text = ((MobileGetTaskNodeGroupForm)this.Owner).BeginDate;
            tbx_end_date.Text = ((MobileGetTaskNodeGroupForm)this.Owner).EndDate;
            tbx_data_type.Text = ((MobileGetTaskNodeGroupForm)this.Owner).DataType;
        }

        private Hashtable GetTaskNodeLstByPageMethod()
        {
            Hashtable hashTable = new Hashtable();
            string userCode = tbx_usercode.Text.Trim();
            string pageNumber = PageNumber;
            string benginDate = tbx_begin_date.Text.Trim();
            string endDate = tbx_end_date.Text;
            string dataType = tbx_data_type.Text.Trim();
            string groupCode = TaskNodeGroupCode;
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
            hashTable.Add("aPage", pageNumber);
            hashTable.Add("aTargetType", targetType);
            hashTable.Add("aUserCode", userCode);
            hashTable.Add("aBeg_date", benginDate);
            hashTable.Add("aEnd_date", endDate);
            hashTable.Add("aDataType", dataType);
            hashTable.Add("aGroupCode", groupCode);

            return hashTable;
        }

        private void btn_singleNodeTree_Click(object sender, EventArgs e)
        {
            // 获取5.3的报文
            // var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeLstByPage", GetTaskNodeLstByPageMethod());
            string xmlstr = @"<rt>
  <RE>
    <RC>0</RC>
    <RM>查询成功</RM>
  </RE>
  <G TID=""4049995"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049998"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049999"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049990"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
</rt>";
            var mobileGetTaskNodeLstByPageList = MobileGetTaskNodeLstByPageXmlProcess.ProcessMobileGetTaskNodeLstByPageXml(xmlstr, ref successInfo);
            // 把TID传给5.4
            _taskIdList = mobileGetTaskNodeLstByPageList.Select(x => x.TID).ToList();
            MobileSingleTaskNodeTreeForm mobileSingleTaskNodeTreeForm = new MobileSingleTaskNodeTreeForm();
            mobileSingleTaskNodeTreeForm.Owner = this;
            mobileSingleTaskNodeTreeForm.Show();
        }

        private void btn_MobileSingleSetPackDetail_Click(object sender, EventArgs e)
        {
            //var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeLstByPage", GetTaskNodeLstByPageMethod());
            string xmlstr = @"<rt>
  <RE>
    <RC>0</RC>
    <RM>查询成功</RM>
  </RE>
  <G TID=""4049995"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049998"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049999"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049990"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
</rt>";
            var mobileGetTaskNodeLstByPageList = MobileGetTaskNodeLstByPageXmlProcess.ProcessMobileGetTaskNodeLstByPageXml(xmlstr, ref successInfo);
            // 把ID传给5.9
            _instIdList = mobileGetTaskNodeLstByPageList.Select(x => x.ID).ToList();
            MobileSingleSetPackDetailForm mobileSingleSetPackDetailForm = new MobileSingleSetPackDetailForm();
            mobileSingleSetPackDetailForm.Owner = this;
            mobileSingleSetPackDetailForm.Show();
        }

        private void btn_singleTradeDetail_Click(object sender, EventArgs e)
        {
            //var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeLstByPage", GetTaskNodeLstByPageMethod());
            string xmlstr = @"<rt>
  <RE>
    <RC>0</RC>
    <RM>查询成功</RM>
  </RE>
  <G TID=""4049995"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049998"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049999"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049990"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
</rt>";
            var mobileGetTaskNodeLstByPageList = MobileGetTaskNodeLstByPageXmlProcess.ProcessMobileGetTaskNodeLstByPageXml(xmlstr, ref successInfo);
            // 把ID传给5.8
            _idList = mobileGetTaskNodeLstByPageList.Select(x => x.ID).ToList();
            MobileSingleTradeDetailForm mobileSingleTradeDetailForm = new MobileSingleTradeDetailForm();
            mobileSingleTradeDetailForm.Owner = this;
            mobileSingleTradeDetailForm.Show();
        }

        private void btn_singleTraceLog_Click(object sender, EventArgs e)
        {
            // 获取5.3的报文
            // var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeLstByPage", GetTaskNodeLstByPageMethod());
            string xmlstr = @"<rt>
  <RE>
    <RC>0</RC>
    <RM>查询成功</RM>
  </RE>
  <G TID=""4049995"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049998"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049999"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049990"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
</rt>";
            var mobileGetTaskNodeLstByPageList = MobileGetTaskNodeLstByPageXmlProcess.ProcessMobileGetTaskNodeLstByPageXml(xmlstr, ref successInfo);
            // 把TID传给5.4
            _taskIdList = mobileGetTaskNodeLstByPageList.Select(x => x.TID).ToList();
            MobileSingleTraceLogForm mobileSingleTraceLogForm = new MobileSingleTraceLogForm();
            mobileSingleTraceLogForm.Owner = this;
            mobileSingleTraceLogForm.Show();
        }

        private void btn_singleLimitresult_Click(object sender, EventArgs e)
        {
            // 获取5.3的报文
            // var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeLstByPage", GetTaskNodeLstByPageMethod());
            string xmlstr = @"<rt>
  <RE>
    <RC>0</RC>
    <RM>查询成功</RM>
  </RE>
  <G TID=""4049995"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049998"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049999"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049990"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
</rt>";
            var mobileGetTaskNodeLstByPageList = MobileGetTaskNodeLstByPageXmlProcess.ProcessMobileGetTaskNodeLstByPageXml(xmlstr, ref successInfo);
            // 把TID传给5.6
            _taskIdList = mobileGetTaskNodeLstByPageList.Select(x => x.TID).ToList();
            MobileSingleLimitresultForm mobileSingleLimitresultForm = new MobileSingleLimitresultForm();
            mobileSingleLimitresultForm.Owner = this;
            mobileSingleLimitresultForm.Show();
        }

        private void btn_singleTradeTarget_Click(object sender, EventArgs e)
        {
            // 获取5.3的报文
            // var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeLstByPage", GetTaskNodeLstByPageMethod());
            string xmlstr = @"<rt>
  <RE>
    <RC>0</RC>
    <RM>查询成功</RM>
  </RE>
  <G TID=""4049995"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049998"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049999"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049990"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
</rt>";
            var mobileGetTaskNodeLstByPageList = MobileGetTaskNodeLstByPageXmlProcess.ProcessMobileGetTaskNodeLstByPageXml(xmlstr, ref successInfo);
            // 把TID传给5.7
            _taskIdList = mobileGetTaskNodeLstByPageList.Select(x => x.TID).ToList();
            MobileSingleTradeTargetForm mobileSingleTradeTargetForm = new MobileSingleTradeTargetForm();
            mobileSingleTradeTargetForm.Owner = this;
            mobileSingleTradeTargetForm.Show();
        }

        private void btn_approveTaskByNodeId_Batch_Click(object sender, EventArgs e)
        {
            //var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileGetTaskNodeLstByPage", GetTaskNodeLstByPageMethod());
            string xmlstr = @"<rt>
  <RE>
    <RC>0</RC>
    <RM>查询成功</RM>
  </RE>
  <G TID=""4049995"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049997"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049998"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049999"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
  <G TID=""4049990"" NID=""4049996"" ID=""405951"" ISN=""secu_lc01"" TR=""cyh_陈映华"" TY=""买入"" IC=""1312001"" IN=""13中信银行债"" IGRADE=""AAA"" BG=""AAA"" SD=""T+0"" CO=""100"" OD=""11-20"" PR=""110707"" ESN=""lc_ec_zzd"" HM=""中债登"" OA=""1,001,136.61"" ORP=""100.1137"" LRATE="""" EVALNO=""0.0000%"" GR=""4049996_admin""></G>
</rt>";
            var mobileGetTaskNodeLstByPageList = MobileGetTaskNodeLstByPageXmlProcess.ProcessMobileGetTaskNodeLstByPageXml(xmlstr, ref successInfo);
            // 把ID传给5.10
            _nodeIdList = mobileGetTaskNodeLstByPageList.Select(x => x.NID).ToList();
            MobileApproveTaskByNodeId_BatchForm mobileApproveTaskByNodeId_BatchForm = new MobileApproveTaskByNodeId_BatchForm();
            mobileApproveTaskByNodeId_BatchForm.Owner = this;
            mobileApproveTaskByNodeId_BatchForm.Show();
        }
    }
}