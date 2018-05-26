namespace IRFixIncomeSystemApprovement
{
    partial class MobileSingleTradeDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_usercode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_sysOrdId = new System.Windows.Forms.ComboBox();
            this.btn_mobileSingleTradeDetail = new System.Windows.Forms.Button();
            this.lbx_singleTradeDetail = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbx_usercode
            // 
            this.tbx_usercode.Location = new System.Drawing.Point(79, 12);
            this.tbx_usercode.Name = "tbx_usercode";
            this.tbx_usercode.Size = new System.Drawing.Size(165, 21);
            this.tbx_usercode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户代码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "交易编号：";
            // 
            // cbb_sysOrdId
            // 
            this.cbb_sysOrdId.FormattingEnabled = true;
            this.cbb_sysOrdId.Location = new System.Drawing.Point(79, 67);
            this.cbb_sysOrdId.Name = "cbb_sysOrdId";
            this.cbb_sysOrdId.Size = new System.Drawing.Size(165, 20);
            this.cbb_sysOrdId.TabIndex = 26;
            // 
            // btn_mobileSingleTradeDetail
            // 
            this.btn_mobileSingleTradeDetail.Location = new System.Drawing.Point(79, 108);
            this.btn_mobileSingleTradeDetail.Name = "btn_mobileSingleTradeDetail";
            this.btn_mobileSingleTradeDetail.Size = new System.Drawing.Size(75, 23);
            this.btn_mobileSingleTradeDetail.TabIndex = 27;
            this.btn_mobileSingleTradeDetail.Text = "查询";
            this.btn_mobileSingleTradeDetail.UseVisualStyleBackColor = true;
            this.btn_mobileSingleTradeDetail.Click += new System.EventHandler(this.btn_mobileSingleTradeDetail_Click);
            // 
            // lbx_singleTradeDetail
            // 
            this.lbx_singleTradeDetail.FormattingEnabled = true;
            this.lbx_singleTradeDetail.ItemHeight = 12;
            this.lbx_singleTradeDetail.Location = new System.Drawing.Point(10, 150);
            this.lbx_singleTradeDetail.Name = "lbx_singleTradeDetail";
            this.lbx_singleTradeDetail.Size = new System.Drawing.Size(257, 100);
            this.lbx_singleTradeDetail.TabIndex = 28;
            // 
            // MobileSingleTradeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbx_singleTradeDetail);
            this.Controls.Add(this.btn_mobileSingleTradeDetail);
            this.Controls.Add(this.cbb_sysOrdId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_usercode);
            this.Controls.Add(this.label1);
            this.Name = "MobileSingleTradeDetailForm";
            this.Text = "单笔交易详情";
            this.Load += new System.EventHandler(this.MobileSingleTradeDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_usercode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_sysOrdId;
        private System.Windows.Forms.Button btn_mobileSingleTradeDetail;
        private System.Windows.Forms.ListBox lbx_singleTradeDetail;
    }
}