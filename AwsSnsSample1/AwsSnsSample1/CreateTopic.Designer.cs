namespace AwsSnsSample1
{
    partial class CreateTopic
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
            this.maketopic = new System.Windows.Forms.Button();
            this.TopicNamebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maketopic
            // 
            this.maketopic.Location = new System.Drawing.Point(113, 64);
            this.maketopic.Name = "maketopic";
            this.maketopic.Size = new System.Drawing.Size(75, 23);
            this.maketopic.TabIndex = 0;
            this.maketopic.Text = "Create";
            this.maketopic.UseVisualStyleBackColor = true;
            this.maketopic.Click += new System.EventHandler(this.maketopic_Click);
            // 
            // TopicNamebox
            // 
            this.TopicNamebox.Location = new System.Drawing.Point(12, 38);
            this.TopicNamebox.Name = "TopicNamebox";
            this.TopicNamebox.Size = new System.Drawing.Size(270, 20);
            this.TopicNamebox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Topic Name";
            // 
            // CreateTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 107);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopicNamebox);
            this.Controls.Add(this.maketopic);
            this.Name = "CreateTopic";
            this.Text = "CreateTopic";
            this.Load += new System.EventHandler(this.CreateTopic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button maketopic;
        private System.Windows.Forms.TextBox TopicNamebox;
        private System.Windows.Forms.Label label1;
    }
}