using System;
using System.Globalization;
using System.Windows.Data;

using ConverterSamples.Resources;

namespace ConverterSamples
{
    public class ItemToDescriptionConverter : IValueConverter
    {
        private const string _DescriptonKeyFormat = "ItemDescription_{0}";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var item = (Models.Item)value;
            var resourceKey = String.Format(_DescriptonKeyFormat, item.Kind);
            return AppResources.ResourceManager.GetString(resourceKey, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
