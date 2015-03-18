using System;
using System.Windows;
using System.Windows.Data;

namespace Devkoes.WP.Volleybal.WP8UI.Converters
{
    public class VisibilityInverterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Visibility? v = value as Visibility?;
            if (v.HasValue)
            {
                return v.Value == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
            }

            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
