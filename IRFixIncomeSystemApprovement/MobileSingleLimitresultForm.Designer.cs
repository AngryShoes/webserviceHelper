namespace IRFixIncomeSystemApprovement
{
    partial class MobileSingleLimitresultForm
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
            this.lbx_singleLimitresult = new System.Windows.Forms.ListBox();
            this.btn_mobileSingleLimitresult = new System.Windows.Forms.Button();
            this.cbb_taskid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_usercode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_isIncludeOrdered = new System.Windows.Forms.TextBox();
            this.tbx_isIncludeConfirmed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_singleLimitresult
            // 
            this.lbx_singleLimitresult.FormattingEnabled = true;
            this.lbx_singleLimitresult.ItemHeight = 12;
            this.lbx_singleLimitresult.Location = new System.Drawing.Point(243, 12);
            this.lbx_singleLimitresult.Name = "lbx_singleLimitresult";
            this.lbx_singleLimitresult.Size = new System.Drawing.Size(257, 148);
            this.lbx_singleLimitresult.TabIndex = 17;
            // 
            // btn_mobileSingleLimitresult
            // 
            this.btn_mobileSingleLimitresult.Location = new System.Drawing.Point(286, 169);
            this.btn_mobileSingleLimitresult.Name = "btn_mobileSingleLimitresult";
            this.btn_mobileSingleLimitresult.Size = new System.Drawing.Size(75, 23);
            this.btn_mobileSingleLimitresult.TabIndex = 16;
            this.btn_mobileSingleLimitresult.Text = "查询";
            this.btn_mobileSingleLimitresult.UseVisualStyleBackColor = true;
            this.btn_mobileSingleLimitresult.Click += new System.EventHandler(this.btn_mobileSingleLimitresult_Click);
            // 
            // cbb_taskid
            // 
            this.cbb_taskid.FormattingEnabled = true;
            this.cbb_taskid.Location = new System.Drawing.Point(93, 74);
            this.cbb_taskid.Name = "cbb_taskid";
            this.cbb_taskid.Size = new System.Drawing.Size(121, 20);
            this.cbb_taskid.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "审批任务ID：";
            // 
            // tbx_usercode
            // 
            this.tbx_usercode.Location = new System.Drawing.Point(93, 14);
            this.tbx_usercode.Name = "tbx_usercode";
            this.tbx_usercode.Size = new System.Drawing.Size(121, 21);
            this.tbx_usercode.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户代码：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 54);
            this.label4.TabIndex = 31;
            this.label4.Text = "是否包括审批中的交易：";
            // 
            // tbx_isIncludeOrdered
            // 
            this.tbx_isIncludeOrdered.Location = new System.Drawing.Point(93, 171);
            this.tbx_isIncludeOrdered.Name = "tbx_isIncludeOrdered";
            this.tbx_isIncludeOrdered.Size = new System.Drawing.Size(121, 21);
            this.tbx_isIncludeOrdered.TabIndex = 30;
            // 
            // tbx_isIncludeConfirmed
            // 
            this.tbx_isIncludeConfirmed.Location = new System.Drawing.Point(93, 113);
            this.tbx_isIncludeConfirmed.Name = "tbx_isIncludeConfirmed";
            this.tbx_isIncludeConfirmed.Size = new System.Drawing.Size(121, 21);
            this.tbx_isIncludeConfirmed.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 54);
            this.label3.TabIndex = 28;
            this.label3.Text = "是否包含审批通过和交易执行的交易：";
            // 
            // MobileSingleLimitresultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 207);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_isIncludeOrdered);
            this.Controls.Add(this.tbx_isIncludeConfirmed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbx_singleLimitresult);
            this.Controls.Add(this.btn_mobileSingleLimitresult);
            this.Controls.Add(this.cbb_taskid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_usercode);
            this.Controls.Add(this.label1);
            this.Name = "MobileSingleLimitresultForm";
            this.Text = "查询限额检查结果";
            this.Load += new System.EventHandler(this.MobileSingleLimitresultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_singleLimitresult;
        private System.Windows.Forms.Button btn_mobileSingleLimitresult;
        private System.Windows.Forms.ComboBox cbb_taskid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_usercode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_isIncludeOrdered;
        private System.Windows.Forms.TextBox tbx_isIncludeConfirmed;
        private System.Windows.Forms.Label label3;
    }
}