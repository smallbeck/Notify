namespace AwsSnsSample1
{
    partial class NotificationSender
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartBt = new System.Windows.Forms.Button();
            this.SetBt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TopicFrm = new System.Windows.Forms.Button();
            this.PublishFrm = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Timer";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(11, 177);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(30, 20);
            this.TimeBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Connection String";
            // 
            // DataString
            // 
            this.DataString.Location = new System.Drawing.Point(7, 121);
            this.DataString.Name = "DataString";
            this.DataString.Size = new System.Drawing.Size(288, 20);
            this.DataString.TabIndex = 19;
            this.DataString.TextChanged += new System.EventHandler(this.DataString_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.StartBt);
            this.groupBox1.Controls.Add(this.SetBt);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.DataString);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TimeBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 211);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Sender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // StartBt
            // 
            this.StartBt.Location = new System.Drawing.Point(239, 177);
            this.StartBt.Name = "StartBt";
            this.StartBt.Size = new System.Drawing.Size(56, 23);
            this.StartBt.TabIndex = 28;
            this.StartBt.Text = "Start";
            this.StartBt.UseVisualStyleBackColor = true;
            this.StartBt.Click += new System.EventHandler(this.StartBt_Click);
            // 
            // SetBt
            // 
            this.SetBt.Location = new System.Drawing.Point(47, 175);
            this.SetBt.Name = "SetBt";
            this.SetBt.Size = new System.Drawing.Size(33, 23);
            this.SetBt.TabIndex = 27;
            this.SetBt.Text = "Set";
            this.SetBt.UseVisualStyleBackColor = true;
            this.SetBt.Click += new System.EventHandler(this.SetBt_Click);
            // 
            // TopicFrm
            // 
            this.TopicFrm.Location = new System.Drawing.Point(102, 28);
            this.TopicFrm.Name = "TopicFrm";
            this.TopicFrm.Size = new System.Drawing.Size(104, 23);
            this.TopicFrm.TabIndex = 38;
            this.TopicFrm.Text = "Create Topic";
            this.TopicFrm.UseVisualStyleBackColor = true;
            this.TopicFrm.Click += new System.EventHandler(this.TopicFrm_Click);
            // 
            // PublishFrm
            // 
            this.PublishFrm.Location = new System.Drawing.Point(102, 58);
            this.PublishFrm.Name = "PublishFrm";
            this.PublishFrm.Size = new System.Drawing.Size(104, 23);
            this.PublishFrm.TabIndex = 39;
            this.PublishFrm.Text = "Send Message";
            this.PublishFrm.UseVisualStyleBackColor = true;
            this.PublishFrm.Click += new System.EventHandler(this.PublishFrm_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "Subscribe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PublishFrm);
            this.groupBox2.Controls.Add(this.TopicFrm);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 135);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual notifications";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Topic Picker";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NotificationSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NotificationSender";
            this.Text = "NotificationSender";
            this.Load += new System.EventHandler(this.NotificationSender_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button TopicFrm;
        private System.Windows.Forms.Button PublishFrm;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SetBt;
        private System.Windows.Forms.Button StartBt;

    }
}