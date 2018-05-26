using System;
using System.Globalization;
using Xamarin.Forms;

namespace Modulo2
{
    public class StatusToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Models.Status status)
            {
                if (status == Models.Status.Ok) return "ok.png";
                if (status == Models.Status.Error) return "error.png";
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => string.Empty;
    }
}
