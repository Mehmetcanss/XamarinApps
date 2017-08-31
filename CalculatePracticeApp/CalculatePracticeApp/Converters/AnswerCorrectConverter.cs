using System;
using System.Globalization;
using Xamarin.Forms;

namespace CalculatePracticeApp.Converters
{
    public class AnswerCorrectConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int val = (int)value;
            if (val == 0)
            {
                ImageSource source = ImageSource.FromFile("incorrect.png");
                return source;
            }
            if(val == 1)
            {
                return ImageSource.FromFile("correct.png");
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
