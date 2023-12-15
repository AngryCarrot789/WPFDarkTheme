using System.Windows;

namespace REghZyFramework.ThemesOLD;

public partial class ColourfulLightTheme
{
    private void CloseWindow_Event(object sender, RoutedEventArgs e)
    {
        if (e.Source != null)
            try
            {
                CloseWind(Window.GetWindow((FrameworkElement)e.Source));
            }
            catch { }
    }

    private void AutoMinimize_Event(object sender, RoutedEventArgs e)
    {
        if (e.Source != null)
            try
            {
                MaximizeRestore(Window.GetWindow((FrameworkElement)e.Source));
            }
            catch { }
    }

    private void Minimize_Event(object sender, RoutedEventArgs e)
    {
        if (e.Source != null)
            try
            {
                MinimizeWind(Window.GetWindow((FrameworkElement)e.Source));
            }
            catch { }
    }

    public static void CloseWind(Window window) => window.Close();

    public static void MaximizeRestore(Window window)
        => window.WindowState = window.WindowState == WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;

    public static void MinimizeWind(Window window) => window.WindowState = WindowState.Minimized;
}