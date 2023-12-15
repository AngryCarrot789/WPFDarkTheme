﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Themes.Converters;

public class BrushToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is SolidColorBrush brush)
        {
            return brush.Color;
        }
        return Colors.Transparent; // Default value if conversion fails
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Color color)
        {
            return new SolidColorBrush(color);
        }
        return Brushes.Transparent; // Default value if conversion fails
    }
}
