
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
            this.SuspendLayout();
            // 
            // BtnMessageListView
            // 
            this.BtnMessageListView.Location = new System.Drawing.Point(9, 10);
            this.BtnMessageListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMessageListView.Name = "BtnMessageListView";
            this.BtnMessageListView.Size = new System.Drawing.Size(152, 23);
            this.BtnMessageListView.TabIndex = 0;
            this.BtnMessageListView.Text = "MessageListView";
            this.BtnMessageListView.UseVisualStyleBackColor = true;
            this.BtnMessageListView.Click += new System.EventHandler(this.BtnMessageListView_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 344);
            this.Controls.Add(this.BtnMessageListView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "组件测试程序";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMessageListView;
    }
}

