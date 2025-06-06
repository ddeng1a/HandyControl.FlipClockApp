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
        public MainWindow()
        {
            InitializeComponent();

            // 通过DI容器获取ViewModel（替代构造函数注入，更符合WPF习惯）
            DataContext = App.Current.Services.GetService<MainViewModel?>();
        }

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