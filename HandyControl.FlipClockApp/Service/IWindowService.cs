using System.Windows;

namespace HandyControl.FlipClockApp.Service
{
    public interface IWindowService
    {
        void SetTopmost(Window window, bool isTopmost);
    }

    public class WindowService : IWindowService
    {
        public void SetTopmost(Window window, bool isTopmost)
        {
            window.Topmost = isTopmost;
        }
    }
}
