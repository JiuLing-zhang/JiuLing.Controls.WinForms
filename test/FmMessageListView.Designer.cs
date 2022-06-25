
namespace JiuLing.Controls.WinForms.Test
{
    partial class FmMessageListView
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
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnAlert = new System.Windows.Forms.Button();
            this.BtnError = new System.Windows.Forms.Button();
            this.messageListView1 = new JiuLing.Controls.WinForms.MessageListView();
            this.SuspendLayout();
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(11, 10);
            this.BtnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(75, 23);
            this.BtnInfo.TabIndex = 1;
            this.BtnInfo.Text = "消息";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnAlert
            // 
            this.BtnAlert.Location = new System.Drawing.Point(90, 10);
            this.BtnAlert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAlert.Name = "BtnAlert";
            this.BtnAlert.Size = new System.Drawing.Size(75, 23);
            this.BtnAlert.TabIndex = 2;
            this.BtnAlert.Text = "警告";
            this.BtnAlert.UseVisualStyleBackColor = true;
            this.BtnAlert.Click += new System.EventHandler(this.BtnAlert_Click);
            // 
            // BtnError
            // 
            this.BtnError.Location = new System.Drawing.Point(169, 10);
            this.BtnError.Margin = new System.Windows.Forms.Padding(2);
            this.BtnError.Name = "BtnError";
            this.BtnError.Size = new System.Drawing.Size(75, 23);
            this.BtnError.TabIndex = 3;
            this.BtnError.Text = "错误";
            this.BtnError.UseVisualStyleBackColor = true;
            this.BtnError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // messageListView1
            // 
            this.messageListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageListView1.Font = new System.Drawing.Font("宋体", 9F);
            this.messageListView1.Location = new System.Drawing.Point(9, 37);
            this.messageListView1.Margin = new System.Windows.Forms.Padding(2);
            this.messageListView1.MaxRows = 25;
            this.messageListView1.Name = "messageListView1";
            this.messageListView1.Size = new System.Drawing.Size(475, 327);
            this.messageListView1.TabIndex = 0;
            // 
            // FmMessageListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 373);
            this.Controls.Add(this.BtnError);
            this.Controls.Add(this.BtnAlert);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.messageListView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FmMessageListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmMessageListView";
            this.Load += new System.EventHandler(this.FmMessageListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MessageListView messageListView1;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnAlert;
        private System.Windows.Forms.Button BtnError;
    }
}