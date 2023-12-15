using System;

namespace FramePFX.Themes;

public enum ThemeType
{
    SoftDark,
    RedBlackTheme,
    DeepDark,
    GreyTheme,
    DarkGreyTheme,
    LightTheme,
}

public static class ThemeTypeExtension
{
    public static string GetName(this ThemeType type) => type switch
    {
        ThemeType.SoftDark => "SoftDark",
        ThemeType.RedBlackTheme => "RedBlackTheme",
        ThemeType.DeepDark => "DeepDark",
        ThemeType.GreyTheme => "GreyTheme",
        ThemeType.DarkGreyTheme => "DarkGreyTheme",
        ThemeType.LightTheme => "LightTheme",
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
    };
}