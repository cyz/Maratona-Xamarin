using System;
using System.Globalization;
using Xamarin.Forms;

namespace Modulo2
{
    public class IntToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is int length)
                return (length > 0);

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isEnabled)
                return isEnabled ? 1 : 0;

            return 0;
        }
    }
}
