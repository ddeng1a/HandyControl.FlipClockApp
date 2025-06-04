using System.Globalization;
using System.Windows.Data;

namespace HandyControl.FlipClockApp.Converter
{
    public class BoolToTopmostTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isTopmost = (bool)value;
            return isTopmost ? "取消置顶" : "置顶";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
