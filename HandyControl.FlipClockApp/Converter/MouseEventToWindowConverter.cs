using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace HandyControl.FlipClockApp.Converter
{
    public class MouseEventToWindowConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MouseEventArgs args && args.Source is DependencyObject obj)
            {
                return Window.GetWindow(obj);
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
