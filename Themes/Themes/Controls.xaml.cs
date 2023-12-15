using System.Windows;

namespace FramePFX.Themes;

public partial class Controls
{
    private void CloseWindow_Event(object sender, RoutedEventArgs e) => CloseWind(Window.GetWindow((FrameworkElement)e.Source));

    private void AutoMinimize_Event(object sender, RoutedEventArgs e) => MaximizeRestore(Window.GetWindow((FrameworkElement)e.Source));

    private void Minimize_Event(object sender, RoutedEventArgs e) => MinimizeWind(Window.GetWindow((FrameworkElement)e.Source));

    public static void CloseWind(Window window) => window.Close();

    public static void MaximizeRestore(Window window)
    {
        switch (window.WindowState)
        {
            case WindowState.Normal:
                window.WindowState = WindowState.Maximized;
                break;

            case WindowState.Minimized:
            case WindowState.Maximized:
                window.WindowState = WindowState.Normal;
                break;
        }
    }

    public static void MinimizeWind(Window window) => window.WindowState = WindowState.Minimized;
}