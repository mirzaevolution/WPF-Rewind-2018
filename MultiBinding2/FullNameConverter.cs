using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Globalization;
namespace MultiBinding2
{
    public class FullNameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string firstName = (string)values[0];
            string middleName = (string)values[1];
            string lastName = (string)values[2];
            firstName = string.IsNullOrEmpty(firstName) ? string.Empty : firstName;
            middleName = string.IsNullOrEmpty(middleName) ? string.Empty : middleName;
            lastName = string.IsNullOrEmpty(lastName) ? string.Empty : lastName;
            string fullName = firstName;
            fullName = string.IsNullOrEmpty(middleName) ? fullName += " " : $"{fullName} {middleName} ";
            fullName += lastName;
            fullName = fullName.Trim();
            return fullName;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
