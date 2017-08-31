using System;
using System.Globalization;
using Xamarin.Forms;

namespace CalculatePracticeApp.Converters
{
    public class DoubleStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val;
            bool isDouble = Double.TryParse(value.ToString(), out val);
            if (isDouble)
            {
                if (val > 0) return value.ToString();
                return "";
            }

            return Activator.CreateInstance(typeof(string));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double converted;
            bool isDouble = Double.TryParse((string)value, out converted);
            if (isDouble)
            {
                return converted;
            }
            return -1;
        }
    }
}
