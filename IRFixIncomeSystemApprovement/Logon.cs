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
    [Serializable]
    public partial class Logon : Form
    {
        #region Filed and Property

        //private Service _service = null;
        private string _url = ConfigurationManager.AppSettings[CN.URL].ToString();

        private List<string> targetTypes = null;

        public List<string> TargetTypes
        {
            get { return targetTypes; }
            set { targetTypes = value; }
        }

        public string UserCode
        {
            get { return tbx_usercode.Text; }
            set { tbx_usercode.Text = value; }
        }

        public string Password
        {
            get { return tbx_password.Text; }
            set { tbx_password.Text = value; }
        }

        public string MacAddress
        {
            get { return tbx_macAddress.Text; }
            set { tbx_macAddress.Text = value; }
        }

        #endregion Filed and Property

        public Logon()
        {
            InitializeComponent();
            AcceptButton = btn_logon;
            //_service = new Service();
        }

        private void btn_logon_Click(object sender, EventArgs e)
        {
            bool isLogonSucess = false;
            string logonSuccessInfo = string.Empty;
            var xmlString = HttpWebRequestProcessor.PostWebService(_url, "MobileLogon", GetLogonMethodHashtable());
            targetTypes = MobileLogonXmlProcess.ProcessMobileLogonXml(xmlString, ref logonSuccessInfo);
            isLogonSucess = logonSuccessInfo == "0" ? true : false;

            if (isLogonSucess)
            {
                if (MessageBox.Show("登录成功") == DialogResult.OK)
                {
                    MobileGetTaskNodeGroupForm mobileGetTaskNodeGroupForm = new MobileGetTaskNodeGroupForm();
                    mobileGetTaskNodeGroupForm.Owner = this;
                    mobileGetTaskNodeGroupForm.Show();
                    this.Visible = false;
                }
            }
            //try
            //{
            //    string logonSucessInfo = _service.MobileLogon(userCode, password, macAddress);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private Hashtable GetLogonMethodHashtable()
        {
            string userCode = UserCode.Trim();
            string password = Password.Trim();
            string macAddress = MacAddress.Trim();
            //object[] arguments = new object[] { userCode, password, macAddress };
            //WebServiceProcessor.WebServiceProcessor.InvokeWebService(_url, "MobileLogon", arguments);
            Hashtable hashTable = new Hashtable();
            hashTable.Add("aUserCode", userCode);
            hashTable.Add("aPwd", password);
            hashTable.Add("aMAC", macAddress);

            return hashTable;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}