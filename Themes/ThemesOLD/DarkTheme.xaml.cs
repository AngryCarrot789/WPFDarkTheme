using System.Windows;

namespace REghZyFramework.ThemesOLD {
    public partial class DarkTheme {
        private void CloseWindow_Event(object sender, RoutedEventArgs e) {
            if (e.Source != null)
                try {
                    this.CloseWind(Window.GetWindow((FrameworkElement) e.Source));
                }
                catch {
                }
        }

        private void AutoMinimize_Event(object sender, RoutedEventArgs e) {
            if (e.Source != null)
                try {
                    this.MaximizeRestore(Window.GetWindow((FrameworkElement) e.Source));
                }
                catch {
                }
        }

        private void Minimize_Event(object sender, RoutedEventArgs e) {
            if (e.Source != null)
                try {
                    this.MinimizeWind(Window.GetWindow((FrameworkElement) e.Source));
                }
                catch {
                }
        }

        public void CloseWind(Window window) => window.Close();

        public void MaximizeRestore(Window window) {
            if (window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Normal;
            else if (window.WindowState == WindowState.Normal)
                window.WindowState = WindowState.Maximized;
        }

        public void MinimizeWind(Window window) => window.WindowState = WindowState.Minimized;
    }
}