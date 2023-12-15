using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Themes.Converters;

public class BrushToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) 
        => value is SolidColorBrush brush ? brush.Color : Colors.Transparent;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
        => value is Color color ? new SolidColorBrush(color) : Brushes.Transparent;
}