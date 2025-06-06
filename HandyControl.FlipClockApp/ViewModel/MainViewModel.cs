using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyControl.FlipClockApp.Model;
using HandyControl.FlipClockApp.Service;

namespace HandyControl.FlipClockApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ISettingsService _settingsService;

        private WidgetSettings _settings;

        [ObservableProperty]
        private double _windowLeft;

        [ObservableProperty]
        private double _windowTop;

        [ObservableProperty]
        private bool _isLocked;

        [ObservableProperty]
        private bool _isTopmost;

        [ObservableProperty]
        private bool _isDragging;

        public MainViewModel(ISettingsService settingsService)
        {
            _settingsService = settingsService;
            _settings = _settingsService.LoadSettings() ?? new WidgetSettings();

            WindowLeft = _settings.Left;
            WindowTop = _settings.Top;
            IsLocked = _settings.IsLocked;
            IsTopmost = _settings.IsTopmost;
        }

        [RelayCommand]
        private void ToggleLocked()
        {
            IsDragging = !IsLocked;
            IsLocked = !IsLocked;
        }

        [RelayCommand]
        private void ToggeleTopmost()
    {
            IsTopmost = !_settings.IsTopmost;
            _settings.IsTopmost = !_settings.IsTopmost;
        }

        [RelayCommand]
        public void SaveSettings()
        {
            _settings.Left = WindowLeft;
            _settings.Top = WindowTop;
            //_settings.IsLocked = IsLocked;
            _settings.IsTopmost = IsTopmost;
            _settingsService.SaveSettings(_settings);
        }
    }
}
