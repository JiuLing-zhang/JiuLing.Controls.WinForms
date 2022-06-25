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
    }
}
