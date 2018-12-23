using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Windows.Media;
using System.Globalization;
namespace MultiBinding
{
    public class RGBConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            SolidColorBrush brush = null;
            if (values == null)
            {
                return brush = new SolidColorBrush(Colors.Black);
            }
            else if (values.Length < 2)
            {
                return brush = new SolidColorBrush(Colors.Black);
            }
            byte red = (byte)((double)values[0]);
            byte green = (byte)((double)values[1]);
            byte blue = (byte)((double)values[2]);
            brush = new SolidColorBrush(Color.FromRgb(red, green, blue));
            return brush;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
