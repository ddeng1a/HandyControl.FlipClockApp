using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace HandyControl.FlipClockApp.Converter
{
    [ValueConversion(typeof(bool), typeof(ResizeMode))]
    class BoolToResizeModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isLocked)
            {
                return isLocked ? ResizeMode.CanResizeWithGrip : ResizeMode.NoResize;
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
