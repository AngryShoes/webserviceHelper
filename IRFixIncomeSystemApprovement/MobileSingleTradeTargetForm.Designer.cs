namespace IRFixIncomeSystemApprovement
{
    partial class MobileSingleTradeTargetForm
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
            this.lbx_singleTradeTarget = new System.Windows.Forms.ListBox();
            this.btn_mobileSingleTradeTarget = new System.Windows.Forms.Button();
            this.cbb_taskid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_usercode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_singleTradeTarget
            // 
            this.lbx_singleTradeTarget.FormattingEnabled = true;
            this.lbx_singleTradeTarget.ItemHeight = 12;
            this.lbx_singleTradeTarget.Location = new System.Drawing.Point(231, 14);
            this.lbx_singleTradeTarget.Name = "lbx_singleTradeTarget";
            this.lbx_singleTradeTarget.Size = new System.Drawing.Size(257, 148);
            this.lbx_singleTradeTarget.TabIndex = 23;
            // 
            // btn_mobileSingleTradeTarget
            // 
            this.btn_mobileSingleTradeTarget.Location = new System.Drawing.Point(29, 118);
            this.btn_mobileSingleTradeTarget.Name = "btn_mobileSingleTradeTarget";
            this.btn_mobileSingleTradeTarget.Size = new System.Drawing.Size(75, 23);
            this.btn_mobileSingleTradeTarget.TabIndex = 22;
            this.btn_mobileSingleTradeTarget.Text = "查询";
            this.btn_mobileSingleTradeTarget.UseVisualStyleBackColor = true;
            this.btn_mobileSingleTradeTarget.Click += new System.EventHandler(this.btn_mobileSingleTradeTarget_Click);
            // 
            // cbb_taskid
            // 
            this.cbb_taskid.FormattingEnabled = true;
            this.cbb_taskid.Location = new System.Drawing.Point(91, 71);
            this.cbb_taskid.Name = "cbb_taskid";
            this.cbb_taskid.Size = new System.Drawing.Size(121, 20);
            this.cbb_taskid.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "审批任务ID：";
            // 
            // tbx_usercode
            // 
            this.tbx_usercode.Location = new System.Drawing.Point(91, 11);
            this.tbx_usercode.Name = "tbx_usercode";
            this.tbx_usercode.Size = new System.Drawing.Size(121, 21);
            this.tbx_usercode.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "用户代码：";
            // 
            // MobileSingleTradeTargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 179);
            this.Controls.Add(this.lbx_singleTradeTarget);
            this.Controls.Add(this.btn_mobileSingleTradeTarget);
            this.Controls.Add(this.cbb_taskid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_usercode);
            this.Controls.Add(this.label1);
            this.Name = "MobileSingleTradeTargetForm";
            this.Text = "查询交易指标";
            this.Load += new System.EventHandler(this.MobileSingleTradeTargetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_singleTradeTarget;
        private System.Windows.Forms.Button btn_mobileSingleTradeTarget;
        private System.Windows.Forms.ComboBox cbb_taskid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_usercode;
        private System.Windows.Forms.Label label1;
    }
}