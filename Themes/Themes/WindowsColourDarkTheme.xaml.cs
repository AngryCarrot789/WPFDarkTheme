using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;
using Themes.Properties;
using Themes.Utilities;

namespace Themes.ThemesFolder
{
    public partial class WindowsColourDarkTheme
    {
        private Brush _titleBrush;
        public Brush TitlebarBrush
        {
            get => _titleBrush;
            set => _titleBrush = value;
        }

        [DllImport("uxtheme.dll", EntryPoint = "#95")]
        public static extern uint GetImmersiveColorFromColorSetEx(uint dwImmersiveColorSet, uint dwImmersiveColorType, bool bIgnoreHighContrast, uint dwHighContrastCacheMode);
        [DllImport("uxtheme.dll", EntryPoint = "#96")]
        public static extern uint GetImmersiveColorTypeFromName(IntPtr pName);
        [DllImport("uxtheme.dll", EntryPoint = "#98")]
        public static extern int GetImmersiveUserColorSetPreference(bool bForceCheckRegistry, bool bSkipCheckOnFail);

        public Color GetThemeColor()
        {
            var colorSetEx = GetImmersiveColorFromColorSetEx(
                (uint)GetImmersiveUserColorSetPreference(false, false),
                GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground")),
                false, 0);

            Color colour = Color.FromArgb((byte)((0xFF000000 & colorSetEx) >> 24), (byte)(0x000000FF & colorSetEx),
                (byte)((0x0000FF00 & colorSetEx) >> 8), (byte)((0x00FF0000 & colorSetEx) >> 16));

            return colour;
        }

        public WindowsColourDarkTheme()
        {
            //ResourceDictionary resDict = Application.Current.Resources.MergedDictionaries[0];
            //if (resDict["WindowTitleColour"] is SolidColorBrush scb)
            //DispatcherTimer dt = new DispatcherTimer();
            //dt.Interval = TimeSpan.FromSeconds(2);
            //dt.Tick += Dt_Tick;
            //dt.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            //ResourceDictionary resDict = Application.Current.Resources.MergedDictionaries[0];
            //if (resDict["WindowTitleColour"] is SolidColorBrush scb)
            //{
            //    scb = new SolidColorBrush(Colors.Green);
            //}
            //
            ////// Set the new value
            ////Application.Current.Resources["MyColor"] = MyCodeColor;
            ////Application.Current.Resources["MyColor2"] = MyBrush;

        }

        private void CloseWindow_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                try { CloseWind(Window.GetWindow((FrameworkElement)e.Source)); } catch { }
        }
        private void AutoMinimize_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                try { MaximizeRestore(Window.GetWindow((FrameworkElement)e.Source)); } catch { }
        }
        private void Minimize_Event(object sender, RoutedEventArgs e)
        {
            if (e.Source != null)
                try { MinimizeWind(Window.GetWindow((FrameworkElement)e.Source)); } catch { }
        }

        public void CloseWind(Window window) => window.Close();
        public void MaximizeRestore(Window window)
        {
            if (window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Normal;
            else if (window.WindowState == WindowState.Normal)
                window.WindowState = WindowState.Maximized;
        }
        public void MinimizeWind(Window window) => window.WindowState = WindowState.Minimized;
    }
}
