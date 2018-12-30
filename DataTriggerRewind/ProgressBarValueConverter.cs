using System;
using System.Globalization;
using System.Windows.Data;

namespace DataTriggerRewind
{
    public class ProgressBarValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int barValue = (int)value;
            if (barValue <= 30)
                return 0;
            else if (barValue >= 31 && barValue <= 60)
                return 1;
            else if (barValue >= 61 && barValue <= 90)
                return 2;
            return 3;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
