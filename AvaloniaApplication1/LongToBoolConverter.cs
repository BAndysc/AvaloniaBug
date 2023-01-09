using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace AvaloniaApplication1;

public class LongToBoolConverter : IValueConverter
{
    public static LongToBoolConverter Instance { get; } = new();
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is long l)
            return l != 0;
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool b)
            return b ? 1L : 0L;
        return null;
    }
}