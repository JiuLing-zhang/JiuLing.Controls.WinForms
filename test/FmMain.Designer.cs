
namespace JiuLing.Controls.WinForms.Test
{
    partial class FmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMessageListView = new System.Windows.Forms.Button();
            this.BtnShowInfo = new System.Windows.Forms.Button();
            this.BtnShowWarn = new System.Windows.Forms.Button();
            this.BtnShowError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMessageListView
            // 
            this.BtnMessageListView.Location = new System.Drawing.Point(11, 10);
            this.BtnMessageListView.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMessageListView.Name = "BtnMessageListView";
            this.BtnMessageListView.Size = new System.Drawing.Size(152, 23);
            this.BtnMessageListView.TabIndex = 0;
            this.BtnMessageListView.Text = "MessageListView";
            this.BtnMessageListView.UseVisualStyleBackColor = true;
            this.BtnMessageListView.Click += new System.EventHandler(this.BtnMessageListView_Click);
            // 
            // BtnShowInfo
            // 
            this.BtnShowInfo.Location = new System.Drawing.Point(12, 38);
            this.BtnShowInfo.Name = "BtnShowInfo";
            this.BtnShowInfo.Size = new System.Drawing.Size(75, 23);
            this.BtnShowInfo.TabIndex = 1;
            this.BtnShowInfo.Text = "消息窗口";
            this.BtnShowInfo.UseVisualStyleBackColor = true;
            this.BtnShowInfo.Click += new System.EventHandler(this.BtnShowInfo_Click);
            // 
            // BtnShowWarn
            // 
            this.BtnShowWarn.Location = new System.Drawing.Point(93, 38);
            this.BtnShowWarn.Name = "BtnShowWarn";
            this.BtnShowWarn.Size = new System.Drawing.Size(75, 23);
            this.BtnShowWarn.TabIndex = 1;
            this.BtnShowWarn.Text = "警告窗口";
            this.BtnShowWarn.UseVisualStyleBackColor = true;
            this.BtnShowWarn.Click += new System.EventHandler(this.BtnShowWarn_Click);
            // 
            // BtnShowError
            // 
            this.BtnShowError.Location = new System.Drawing.Point(174, 38);
            this.BtnShowError.Name = "BtnShowError";
            this.BtnShowError.Size = new System.Drawing.Size(75, 23);
            this.BtnShowError.TabIndex = 2;
            this.BtnShowError.Text = "错误窗口";
            this.BtnShowError.UseVisualStyleBackColor = true;
            this.BtnShowError.Click += new System.EventHandler(this.BtnShowError_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 344);
            this.Controls.Add(this.BtnShowError);
            this.Controls.Add(this.BtnShowWarn);
            this.Controls.Add(this.BtnShowInfo);
            this.Controls.Add(this.BtnMessageListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "组件测试程序";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMessageListView;
        private System.Windows.Forms.Button BtnShowInfo;
        private System.Windows.Forms.Button BtnShowWarn;
        private System.Windows.Forms.Button BtnShowError;
    }
}

