using CommunityToolkit.Mvvm.ComponentModel;

namespace HandyControl.FlipClockApp.Model
{
    public partial class WidgetSettings : ObservableObject
    {
        [ObservableProperty]
        private int _windowTop;
        [ObservableProperty]
        private int _windowLeft;
    }
}
