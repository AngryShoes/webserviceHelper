namespace IRFixIncomeSystemApprovement
{
    partial class MobileGetTaskNodeGroupForm
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
            this.cbb_targetType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_usercode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_begin_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_end_date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_data_type = new System.Windows.Forms.TextBox();
            this.btn_mobile_get_task_node_group = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbb_targetType
            // 
            this.cbb_targetType.FormattingEnabled = true;
            this.cbb_targetType.Location = new System.Drawing.Point(86, 12);
            this.cbb_targetType.Name = "cbb_targetType";
            this.cbb_targetType.Size = new System.Drawing.Size(100, 20);
            this.cbb_targetType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "审批类型:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户代码：";
            // 
            // tbx_usercode
            // 
            this.tbx_usercode.Location = new System.Drawing.Point(86, 63);
            this.tbx_usercode.Name = "tbx_usercode";
            this.tbx_usercode.Size = new System.Drawing.Size(100, 21);
            this.tbx_usercode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "起始日期：";
            // 
            // tbx_begin_date
            // 
            this.tbx_begin_date.Location = new System.Drawing.Point(86, 106);
            this.tbx_begin_date.Name = "tbx_begin_date";
            this.tbx_begin_date.Size = new System.Drawing.Size(100, 21);
            this.tbx_begin_date.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "结束日期：";
            // 
            // tbx_end_date
            // 
            this.tbx_end_date.Location = new System.Drawing.Point(86, 144);
            this.tbx_end_date.Name = "tbx_end_date";
            this.tbx_end_date.Size = new System.Drawing.Size(100, 21);
            this.tbx_end_date.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据类型：";
            // 
            // tbx_data_type
            // 
            this.tbx_data_type.Location = new System.Drawing.Point(86, 181);
            this.tbx_data_type.Name = "tbx_data_type";
            this.tbx_data_type.Size = new System.Drawing.Size(100, 21);
            this.tbx_data_type.TabIndex = 9;
            // 
            // btn_mobile_get_task_node_group
            // 
            this.btn_mobile_get_task_node_group.Location = new System.Drawing.Point(72, 227);
            this.btn_mobile_get_task_node_group.Name = "btn_mobile_get_task_node_group";
            this.btn_mobile_get_task_node_group.Size = new System.Drawing.Size(114, 23);
            this.btn_mobile_get_task_node_group.TabIndex = 10;
            this.btn_mobile_get_task_node_group.Text = "查询审批数据分组";
            this.btn_mobile_get_task_node_group.UseVisualStyleBackColor = true;
            this.btn_mobile_get_task_node_group.Click += new System.EventHandler(this.btn_mobile_get_task_node_group_Click);
            // 
            // MobileGetTaskNodeGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_mobile_get_task_node_group);
            this.Controls.Add(this.tbx_data_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_end_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_begin_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_usercode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_targetType);
            this.Name = "MobileGetTaskNodeGroupForm";
            this.Text = "查询审批数据分组信息";
            this.Load += new System.EventHandler(this.MobileGetTaskNodeGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_targetType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_usercode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_begin_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_end_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_data_type;
        private System.Windows.Forms.Button btn_mobile_get_task_node_group;
    }
}