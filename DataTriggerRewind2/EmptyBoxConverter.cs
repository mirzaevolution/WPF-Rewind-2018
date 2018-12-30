using System;
using System.Globalization;
using System.Windows.Data;
namespace DataTriggerRewind2
{
    public class EmptyBoxConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = (string)value;
            if (string.IsNullOrEmpty(text))
                return 0;
            return 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
