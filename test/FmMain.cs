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
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnMessageListView_Click(object sender, EventArgs e)
        {
            (new FmMessageListView()).ShowDialog();
        }

        private void BtnShowInfo_Click(object sender, EventArgs e)
        {
            MessageBoxUtils.SetTitle("我的测试程序");
            MessageBoxUtils.ShowInfo("这是一条消息");
        }

        private void BtnShowWarn_Click(object sender, EventArgs e)
        {
            MessageBoxUtils.ShowWarn("这是一条警告");
        }

        private void BtnShowError_Click(object sender, EventArgs e)
        {
            MessageBoxUtils.SetTitle("我的测试程序");
            MessageBoxUtils.ShowError("这是一条错误");
        }
    }
}
