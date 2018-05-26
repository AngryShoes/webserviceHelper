namespace IRFixIncomeSystemApprovement
{
    partial class MobileSingleTaskNodeTreeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_usercode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_taskid = new System.Windows.Forms.ComboBox();
            this.btn_mobileSingleTaskNodeTree = new System.Windows.Forms.Button();
            this.lbx_singletask = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户代码：";
            // 
            // tbx_usercode
            // 
            this.tbx_usercode.Location = new System.Drawing.Point(84, 10);
            this.tbx_usercode.Name = "tbx_usercode";
            this.tbx_usercode.Size = new System.Drawing.Size(121, 21);
            this.tbx_usercode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "审批任务ID：";
            // 
            // cbb_taskid
            // 
            this.cbb_taskid.FormattingEnabled = true;
            this.cbb_taskid.Location = new System.Drawing.Point(84, 70);
            this.cbb_taskid.Name = "cbb_taskid";
            this.cbb_taskid.Size = new System.Drawing.Size(121, 20);
            this.cbb_taskid.TabIndex = 3;
            // 
            // btn_mobileSingleTaskNodeTree
            // 
            this.btn_mobileSingleTaskNodeTree.Location = new System.Drawing.Point(94, 105);
            this.btn_mobileSingleTaskNodeTree.Name = "btn_mobileSingleTaskNodeTree";
            this.btn_mobileSingleTaskNodeTree.Size = new System.Drawing.Size(75, 23);
            this.btn_mobileSingleTaskNodeTree.TabIndex = 4;
            this.btn_mobileSingleTaskNodeTree.Text = "查询";
            this.btn_mobileSingleTaskNodeTree.UseVisualStyleBackColor = true;
            this.btn_mobileSingleTaskNodeTree.Click += new System.EventHandler(this.btn_mobileSingleTaskNodeTree_Click);
            // 
            // lbx_singletask
            // 
            this.lbx_singletask.FormattingEnabled = true;
            this.lbx_singletask.ItemHeight = 12;
            this.lbx_singletask.Location = new System.Drawing.Point(15, 145);
            this.lbx_singletask.Name = "lbx_singletask";
            this.lbx_singletask.Size = new System.Drawing.Size(257, 100);
            this.lbx_singletask.TabIndex = 5;
            // 
            // MobileSingleTaskNodeTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.lbx_singletask);
            this.Controls.Add(this.btn_mobileSingleTaskNodeTree);
            this.Controls.Add(this.cbb_taskid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_usercode);
            this.Controls.Add(this.label1);
            this.Name = "MobileSingleTaskNodeTreeForm";
            this.Text = "查询单笔审批";
            this.Load += new System.EventHandler(this.MobileSingleTaskNodeTreeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_usercode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_taskid;
        private System.Windows.Forms.Button btn_mobileSingleTaskNodeTree;
        private System.Windows.Forms.ListBox lbx_singletask;
    }
}