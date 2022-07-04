using System.Windows.Forms;

namespace JiuLing.Controls.WinForms
{
    /// <summary>
    /// 显示消息窗口
    /// </summary>
    public class MessageBoxUtils
    {
        private MessageBoxUtils()
        {

        }

        private static string _caption = "";
        /// <summary>
        /// 设置窗口标题
        /// </summary>
        /// <param name="title">标题</param>
        public static void SetTitle(string title)
        {
            _caption = title;
        }
        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="text">内容</param>
        public static void ShowInfo(string text)
        {
            MessageBox.Show(text, _caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 显示警告
        /// </summary>
        /// <param name="text">内容</param>
        public static void ShowWarn(string text)
        {
            MessageBox.Show(text, _caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// 显示错误
        /// </summary>
        /// <param name="text">内容</param>
        public static void ShowError(string text)
        {
            MessageBox.Show(text, _caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
