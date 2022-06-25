
namespace JiuLing.Controls.WinForms
{
    partial class MessageListView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageListView));
            this.MyListView = new System.Windows.Forms.ListView();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // MyListView
            // 
            this.MyListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyListView.HideSelection = false;
            this.MyListView.Location = new System.Drawing.Point(0, 0);
            this.MyListView.Margin = new System.Windows.Forms.Padding(2);
            this.MyListView.Name = "MyListView";
            this.MyListView.Size = new System.Drawing.Size(533, 270);
            this.MyListView.TabIndex = 0;
            this.MyListView.UseCompatibleStateImageBehavior = false;
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Info");
            this.Images.Images.SetKeyName(1, "Alert");
            this.Images.Images.SetKeyName(2, "Error");
            // 
            // MessageListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MyListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MessageListView";
            this.Size = new System.Drawing.Size(533, 270);
            this.Load += new System.EventHandler(this.MessageListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView MyListView;
        private System.Windows.Forms.ImageList Images;
    }
}
