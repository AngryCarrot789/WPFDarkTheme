using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace Theme.Avalonia.Themes.Converters;

public class GroupBoxGapToThicknessConverter : IValueConverter
{
    public static GroupBoxGapToThicknessConverter Instance { get; } = new GroupBoxGapToThicknessConverter();

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == AvaloniaProperty.UnsetValue)
            return value;

        if (!(value is double gap))
            throw new Exception("Expected double, got " + value);

        return new Thickness(0, 0, 0, gap);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == AvaloniaProperty.UnsetValue)
            return value;

        if (!(value is Thickness gap))
            throw new Exception("Expected Thickness, got " + value);

        return gap.Bottom;
    }
}