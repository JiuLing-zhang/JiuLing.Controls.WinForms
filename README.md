![](https://img.shields.io/github/license/JiuLing-zhang/JiuLing.Controls.WinForms)
[![](https://img.shields.io/nuget/v/JiuLing.Controls.WinForms)](https://www.nuget.org/packages/JiuLing.Controls.WinForms/)  

## 1. JiuLing.Controls.WinForms
一个WinForms下的控件库

## 2. 开始使用

### 提示对话框（MessageBoxUtils）
底层使用`MessageBox.Show`的弹窗扩展。

```C#
//设置全局的弹窗标题，（caption参数）
MessageBoxUtils.SetTitle("测试程序");
```
```C#
//显示消息，MessageBoxIcon.Information
MessageBoxUtils.ShowInfo("这是一条消息");

//显示警告，MessageBoxIcon.Warning
MessageBoxUtils.ShowWarn("这是一条警告");

//显示错误，MessageBoxIcon.Error
MessageBoxUtils.ShowError("这是一条错误");
```

### 日志打印组件（MessageListView）

属性
```C#
//日志显示最大行数
MessageListView.MaxRows=100;

//日志详情列宽
MessageListView.MessageColumnWidth=400;

//日志的排序方式
MessageListView.OrderBy=Enums.OrderByEnum.ASC;
```

方法
```C#
//显示消息
MessageListView.ShowInfo(DateTime.Now, $"这是一条消息");

//显示警告
MessageListView.ShowWarn(DateTime.Now, $"这是一条警告");

//显示错误
MessageListView.ShowError(DateTime.Now, $"这是一条错误");
```

## 3. License
本项目基于`MIT License`