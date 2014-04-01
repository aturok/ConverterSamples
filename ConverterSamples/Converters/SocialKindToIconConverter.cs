using System;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace ConverterSamples
{
    public class SocialKindToIconConverter : IValueConverter
    {
        private const string _ImagePathFormat = "Assets/SocialIcons/social_{0}.png";
        private ImageSourceConverter _sourceConverter;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var kind = (string)value;
            var path = String.Format(_ImagePathFormat, kind);
            return _sourceConverter.ConvertFromString(path);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public SocialKindToIconConverter()
        {
            _sourceConverter = new ImageSourceConverter();
        }
    }
}
