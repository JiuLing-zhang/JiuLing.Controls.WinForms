using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using JiuLing.Controls.WinForms.Enums;
using JiuLing.Controls.WinForms.ExtensionMethods;

namespace JiuLing.Controls.WinForms
{
    public partial class MessageListView : UserControl
    {
        private const int MaxRowsDefault = 1000;

        [Browsable(true)]
        [Description("消息显示时的排序方式"), Category("扩展"), DefaultValue(OrderByEnum.ASC)]
        public OrderByEnum OrderBy { get; set; }


        [Browsable(true)]
        [Description("消息的最大显示行数（超过则自动删除老的消息）"), Category("扩展"), DefaultValue(MaxRowsDefault)]
        public int MaxRows { get; set; }


        private const int MessageColumnWidthDefault = 400;
        [Browsable(true)]
        [Description("消息列的宽度"), Category("扩展"), DefaultValue(MessageColumnWidthDefault)]
        public int MessageColumnWidth { get; set; }

        private delegate void AddListView(ListViewItem item);

        private delegate void RemoveListView(int rowIndex);

        public MessageListView()
        {
            InitializeComponent();
        }

        private void MessageListView_Load(object sender, EventArgs e)
        {
            InitializeControl();
        }

        private void InitializeControl()
        {
            if (MessageColumnWidth <= 0)
            {
                MessageColumnWidth = MessageColumnWidthDefault;
            }

            MyListView.View = View.Details;
            MyListView.SmallImageList = Images;
            MyListView.Columns.Add("类型", 60);
            MyListView.Columns.Add("时间", 150);
            MyListView.Columns.Add("消息", MessageColumnWidth);

        }
        public void ShowInfo(DateTime time, string message)
        {
            ShowMessage(MessageTypeEnum.Info, time, message, Color.FromArgb(0, 0, 0));
        }
        public void ShowAlert(DateTime time, string message)
        {
            ShowMessage(MessageTypeEnum.Alert, time, message, Color.FromArgb(233, 132, 33));
        }
        public void ShowError(DateTime time, string message)
        {
            ShowMessage(MessageTypeEnum.Error, time, message, Color.FromArgb(216, 30, 6));
        }

        private void ShowMessage(MessageTypeEnum messageType, DateTime time, string message, Color color)
        {
            var item = new ListViewItem(messageType.GetDescription(), $"{messageType}");
            item.SubItems.Add(time.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(message);
            item.ForeColor = color;
            AddListViewItem(item);
            ClearOldRows();
        }

        private void AddListViewItem(ListViewItem item)
        {
            if (MyListView.InvokeRequired)
            {
                AddListView lst = new AddListView(AddListViewItem);
                this.Invoke(lst, item);
                return;
            }

            switch (OrderBy)
            {
                case OrderByEnum.ASC:
                    MyListView.Items.Add(item);
                    MyListView.EnsureVisible(MyListView.Items.Count - 1);
                    break;
                case OrderByEnum.DESC:
                    MyListView.Items.Insert(0, item);
                    MyListView.EnsureVisible(0);
                    break;
                default:
                    throw new ArgumentException("不支持的排序方式");
            }
        }
        private void ClearOldRows()
        {
            if (MaxRows <= 0)
            {
                MaxRows = MaxRowsDefault;
            }

            int removeCount = MyListView.Items.Count - MaxRows;
            if (removeCount <= 0)
            {
                return;
            }

            for (int i = 0; i < removeCount; i++)
            {
                switch (OrderBy)
                {
                    case OrderByEnum.ASC:
                        RemoveList(0);
                        break;
                    case OrderByEnum.DESC:
                        RemoveList(MyListView.Items.Count - 1);
                        break;
                    default:
                        throw new ArgumentException("不支持的排序方式");
                }
            }
        }

        private void RemoveList(int rowIndex)
        {
            if (MyListView.InvokeRequired)
            {
                RemoveListView lst = new RemoveListView(RemoveList);
                this.Invoke(lst, rowIndex);
                return;
            }
            MyListView.Items.RemoveAt(rowIndex);
        }
    }
}
