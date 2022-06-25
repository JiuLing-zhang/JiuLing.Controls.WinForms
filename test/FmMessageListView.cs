using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiuLing.Controls.WinForms.Test
{
    public partial class FmMessageListView : Form
    {
        public FmMessageListView()
        {
            InitializeComponent();
        }

        private void FmMessageListView_Load(object sender, EventArgs e)
        {

        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                messageListView1.ShowInfo(DateTime.Now, $"消息{i}--这是一条测试信息(test info)");
            }
        }

        private void BtnAlert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                messageListView1.ShowAlert(DateTime.Now, $"警告{i}--这是一条测试信息(test info)");
            }
        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    messageListView1.ShowError(DateTime.Now, $"错误{i}--这是一条测试信息(test info)");
                }
            });
          
        }
    }
}
