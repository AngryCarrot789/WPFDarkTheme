using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using System;

namespace SharpPad.Themes;

public class JetTheme : Styles
{
    public JetTheme(IServiceProvider? sp = null) => AvaloniaXamlLoader.Load(sp, this);
}