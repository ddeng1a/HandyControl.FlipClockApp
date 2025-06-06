using CommunityToolkit.Mvvm.ComponentModel;

namespace HandyControl.FlipClockApp.Model
{
    public partial class WidgetSettings
    {
        public double Left { get; set; } = 1200;
        public double Top { get; set; } = 100;
        public bool IsLocked { get; set; } = false;
        public bool IsTopmost { get; set; } = false;
    }
}
