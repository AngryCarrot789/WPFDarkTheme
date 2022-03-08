namespace REghZy.Themes {
    public enum ThemeType {
        Dark,
        Red,
        Light,
    }

    public static class ThemeTypeExtension {
        public static string GetName(this ThemeType type) {
            switch (type) {
                case ThemeType.Light:
                    return "Dark_DarkBackLightBorder";
                case ThemeType.Dark:
                    return "Dark_DarkBackDarkBorder";
                case ThemeType.Red:
                    return "RedBlackTheme";
                default:
                    return null;
            }
        }
    }
}