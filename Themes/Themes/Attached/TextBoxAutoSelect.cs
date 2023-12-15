using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace FramePFX.Themes.Attached;

public static class TextBoxAutoSelect
{
    private static readonly RoutedEventHandler _handler = ControlOnLoaded;

    public static readonly DependencyProperty IsEnabledProperty = DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(TextBoxAutoSelect), new PropertyMetadata(false, PropertyChangedCallback));

    private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is Control control)
            control.Loaded += _handler;
    }

    private static void ControlOnLoaded(object sender, RoutedEventArgs e)
    {
        if (sender is not Control control)
            return;
        
        control.Focus();
        if (control is TextBoxBase textbox)
            textbox.SelectAll();

        control.Loaded -= _handler;
    }

    public static void SetIsEnabled(DependencyObject element, bool value) => element.SetValue(IsEnabledProperty, value);

    public static bool GetIsEnabled(DependencyObject element) => (bool)element.GetValue(IsEnabledProperty);
}