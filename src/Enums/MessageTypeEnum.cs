using System.ComponentModel;

namespace JiuLing.Controls.WinForms.Enums
{
    internal enum MessageTypeEnum
    {
        [Description("消息")]
        Info,
        [Description("警告")]
        Alert,
        [Description("错误")]
        Error,
    }
}
