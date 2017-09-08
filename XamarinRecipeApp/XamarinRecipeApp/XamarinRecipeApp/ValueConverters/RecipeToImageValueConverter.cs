using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinRecipeApp.ValueConverters
{
    public class RecipeToImageValueConverter : IValueConverter
    {
        public string Assembly { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var source = value as string;
            if(string.IsNullOrEmpty(source))
            {
                return null;
            }
            //$ is for string.format
            var imagePath = $"{Assembly}.{source}";
            var imagesource = ImageSource.FromResource(imagePath);
            return ImageSource.FromResource(imagePath);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
