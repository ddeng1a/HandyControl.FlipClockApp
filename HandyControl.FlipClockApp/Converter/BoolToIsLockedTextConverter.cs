using System.Globalization;
using System.Windows.Data;

namespace HandyControl.FlipClockApp.Converter
{
    public class BoolToIsLockedTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isLocked = (bool)value;
            return isLocked ? "锁定" : "解锁"; throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
