using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace Theme.Avalonia.Themes.Controls;

/// <summary>
/// A headered content control which has a piece of text at the top left, and content below
/// </summary>
public class GroupBox : HeaderedContentControl
{
    public static readonly StyledProperty<IBrush> HeaderBrushProperty = AvaloniaProperty.Register<GroupBox, IBrush>("HeaderBrush", Brushes.Transparent);
    public static readonly StyledProperty<double> HeaderContentGapProperty = AvaloniaProperty.Register<GroupBox, double>("HeaderContentGap", 1.0);

    public IBrush HeaderBrush
    {
        get => this.GetValue(HeaderBrushProperty);
        set => this.SetValue(HeaderBrushProperty, value);
    }

    public double HeaderContentGap
    {
        get => this.GetValue(HeaderContentGapProperty);
        set => this.SetValue(HeaderContentGapProperty, value);
    }

    public GroupBox()
    {

    }
}