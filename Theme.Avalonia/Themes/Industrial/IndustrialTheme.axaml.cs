using System;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Theme.Avalonia.Themes.Industrial;

public class IndustrialTheme : Styles
{
    public IndustrialTheme(IServiceProvider? sp = null) => AvaloniaXamlLoader.Load(sp, this);
}