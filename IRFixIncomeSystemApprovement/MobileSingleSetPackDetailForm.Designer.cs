namespace IRFixIncomeSystemApprovement
{
    partial class MobileSingleSetPackDetailForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_aInstId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_mobileSingleSetPackDetail = new System.Windows.Forms.Button();
            this.lbx_mobileSingleSetPackDetail = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbx_usercode
            // 
            this.tbx_usercode.Location = new System.Drawing.Point(89, 12);
            this.tbx_usercode.Name = "tbx_usercode";
            this.tbx_usercode.Size = new System.Drawing.Size(165, 21);
            this.tbx_usercode.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "用户代码：";
            // 
            // cbb_aInstId
            // 
            this.cbb_aInstId.FormattingEnabled = true;
            this.cbb_aInstId.Location = new System.Drawing.Point(89, 55);
            this.cbb_aInstId.Name = "cbb_aInstId";
            this.cbb_aInstId.Size = new System.Drawing.Size(165, 20);
            this.cbb_aInstId.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "指令编号：";
            // 
            // btn_mobileSingleSetPackDetail
            // 
            this.btn_mobileSingleSetPackDetail.Location = new System.Drawing.Point(89, 95);
            this.btn_mobileSingleSetPackDetail.Name = "btn_mobileSingleSetPackDetail";
            this.btn_mobileSingleSetPackDetail.Size = new System.Drawing.Size(75, 23);
            this.btn_mobileSingleSetPackDetail.TabIndex = 26;
            this.btn_mobileSingleSetPackDetail.Text = "查询";
            this.btn_mobileSingleSetPackDetail.UseVisualStyleBackColor = true;
            this.btn_mobileSingleSetPackDetail.Click += new System.EventHandler(this.btn_mobileSingleSetPackDetail_Click);
            // 
            // lbx_mobileSingleSetPackDetail
            // 
            this.lbx_mobileSingleSetPackDetail.FormattingEnabled = true;
            this.lbx_mobileSingleSetPackDetail.ItemHeight = 12;
            this.lbx_mobileSingleSetPackDetail.Location = new System.Drawing.Point(17, 143);
            this.lbx_mobileSingleSetPackDetail.Name = "lbx_mobileSingleSetPackDetail";
            this.lbx_mobileSingleSetPackDetail.Size = new System.Drawing.Size(313, 88);
            this.lbx_mobileSingleSetPackDetail.TabIndex = 27;
            // 
            // MobileSingleSetPackDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 262);
            this.Controls.Add(this.lbx_mobileSingleSetPackDetail);
            this.Controls.Add(this.btn_mobileSingleSetPackDetail);
            this.Controls.Add(this.cbb_aInstId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_usercode);
            this.Controls.Add(this.label2);
            this.Name = "MobileSingleSetPackDetailForm";
            this.Text = "查询单笔指令详情";
            this.Load += new System.EventHandler(this.MobileSingleSetPackDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_usercode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_aInstId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_mobileSingleSetPackDetail;
        private System.Windows.Forms.ListBox lbx_mobileSingleSetPackDetail;
    }
}