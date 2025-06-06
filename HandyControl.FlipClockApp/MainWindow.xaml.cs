using HandyControl.FlipClockApp.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Input;

namespace HandyControl.FlipClockApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            // 通过DI容器获取ViewModel（替代构造函数注入，更符合WPF习惯）
            DataContext = App.Current.Services.GetService<MainViewModel>();

            //// 使用弱事件模式避免内存泄漏
            //Loaded += OnWindowLoaded;
            //Closed += OnWindowClosed;
        }

        //protected override void OnClosed(EventArgs e)
        //{
        //    // 保存设置
        //    if (DataContext is MainViewModel vm)
        //    {
        //        vm.SaveSettings();
        //    }

        //    // 清理事件引用
        //    Loaded -= OnWindowLoaded;
        //    Closed -= OnWindowClosed;
        //}

        //private void OnWindowLoaded(object sender, RoutedEventArgs e)
        //{
        //    // 初始化窗口位置（如果使用自定义chrome需要特殊处理）
        //    if (DataContext is MainViewModel vm)
        //    {
        //        Left = vm.Settings.Left;
        //        Top = vm.Settings.Top;
        //    }
        //}

        //private void OnWindowClosed(object? sender, EventArgs e)
        //{
        //    // 保存设置
        //    if (DataContext is MainViewModel vm)
        //    {
        //        vm.SaveSettings();
        //    }

        //    // 清理事件引用
        //    Loaded -= OnWindowLoaded;
        //    Closed -= OnWindowClosed;
        //}

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is MainViewModel vm)
            {
                if (vm.IsDragging)
                { 
                    // 保持事件处理最小化
                    if (e.LeftButton == MouseButtonState.Pressed && WindowStyle == WindowStyle.None)
        {
                        DragMove();
                    }
                }

            }
        }
    }
}