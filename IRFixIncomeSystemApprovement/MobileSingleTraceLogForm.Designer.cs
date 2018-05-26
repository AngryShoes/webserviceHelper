namespace IRFixIncomeSystemApprovement
{
    partial class MobileSingleTraceLogForm
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
            this.lbx_singleTraceLog = new System.Windows.Forms.ListBox();
            this.btn_mobileSingleTraceLog = new System.Windows.Forms.Button();
            this.cbb_taskid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_usercode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_singleTraceLog
            // 
            this.lbx_singleTraceLog.FormattingEnabled = true;
            this.lbx_singleTraceLog.ItemHeight = 12;
            this.lbx_singleTraceLog.Location = new System.Drawing.Point(15, 149);
            this.lbx_singleTraceLog.Name = "lbx_singleTraceLog";
            this.lbx_singleTraceLog.Size = new System.Drawing.Size(257, 100);
            this.lbx_singleTraceLog.TabIndex = 11;
            // 
            // btn_mobileSingleTraceLog
            // 
            this.btn_mobileSingleTraceLog.Location = new System.Drawing.Point(94, 109);
            this.btn_mobileSingleTraceLog.Name = "btn_mobileSingleTraceLog";
            this.btn_mobileSingleTraceLog.Size = new System.Drawing.Size(75, 23);
            this.btn_mobileSingleTraceLog.TabIndex = 10;
            this.btn_mobileSingleTraceLog.Text = "查询";
            this.btn_mobileSingleTraceLog.UseVisualStyleBackColor = true;
            this.btn_mobileSingleTraceLog.Click += new System.EventHandler(this.btn_mobileSingleTaskNodeTree_Click);
            // 
            // cbb_taskid
            // 
            this.cbb_taskid.FormattingEnabled = true;
            this.cbb_taskid.Location = new System.Drawing.Point(84, 74);
            this.cbb_taskid.Name = "cbb_taskid";
            this.cbb_taskid.Size = new System.Drawing.Size(121, 20);
            this.cbb_taskid.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "审批任务ID：";
            // 
            // tbx_usercode
            // 
            this.tbx_usercode.Location = new System.Drawing.Point(84, 14);
            this.tbx_usercode.Name = "tbx_usercode";
            this.tbx_usercode.Size = new System.Drawing.Size(121, 21);
            this.tbx_usercode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户代码：";
            // 
            // MobileSingleTraceLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbx_singleTraceLog);
            this.Controls.Add(this.btn_mobileSingleTraceLog);
            this.Controls.Add(this.cbb_taskid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_usercode);
            this.Controls.Add(this.label1);
            this.Name = "MobileSingleTraceLogForm";
            this.Text = "查询审批日志";
            this.Load += new System.EventHandler(this.MobileSingleTraceLogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_singleTraceLog;
        private System.Windows.Forms.Button btn_mobileSingleTraceLog;
        private System.Windows.Forms.ComboBox cbb_taskid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_usercode;
        private System.Windows.Forms.Label label1;
    }
}