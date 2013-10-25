namespace AwsSnsSample1
{
    partial class SendMessage
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
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.NoDatabt = new System.Windows.Forms.Button();
            this.TopicList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(353, 85);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(288, 266);
            this.MessageBox.TabIndex = 32;
            this.MessageBox.Text = "";
            // 
            // NoDatabt
            // 
            this.NoDatabt.Location = new System.Drawing.Point(585, 357);
            this.NoDatabt.Name = "NoDatabt";
            this.NoDatabt.Size = new System.Drawing.Size(56, 20);
            this.NoDatabt.TabIndex = 31;
            this.NoDatabt.Text = "Send";
            this.NoDatabt.UseVisualStyleBackColor = true;
            this.NoDatabt.Click += new System.EventHandler(this.NoDatabt_Click);
            // 
            // TopicList
            // 
            this.TopicList.FormattingEnabled = true;
            this.TopicList.Location = new System.Drawing.Point(12, 35);
            this.TopicList.Name = "TopicList";
            this.TopicList.Size = new System.Drawing.Size(293, 316);
            this.TopicList.TabIndex = 33;
            this.TopicList.SelectedIndexChanged += new System.EventHandler(this.TopicList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Select Topic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Message:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Subject";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(353, 35);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(288, 20);
            this.subjectBox.TabIndex = 37;
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 412);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopicList);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.NoDatabt);
            this.Name = "SendMessage";
            this.Text = "SendMessage";
            this.Load += new System.EventHandler(this.SendMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageBox;
        private System.Windows.Forms.Button NoDatabt;
        private System.Windows.Forms.ListBox TopicList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectBox;
    }
}