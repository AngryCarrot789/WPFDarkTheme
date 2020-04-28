using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Themes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static App CurrentApp;
        public enum Theme
        {
            Dark, Light
        }
        public MainWindow(App currApp)
        {
            InitializeComponent();
            CurrentApp = currApp;
            //SetTheme(Theme.Light);
        }

        public static void SetTheme(Theme theme)
        {
            if (CurrentApp != null)
                CurrentApp.SetTheme(theme);
        }

        public void CloseWindow()
        {
            //WindowStyle = WindowStyle.SingleBorderWindow;
            this.Close();
        }

        public void MaximizeRestore()
        {
            //WindowChrome chrome = WindowChrome.GetWindowChrome(this);
            //chrome.ResizeBorderThickness = new Thickness(10, 10, 10, 10);
            if (this.WindowState == WindowState.Maximized)
            {
                //WindowStyle = WindowStyle.SingleBorderWindow;
                WindowState = WindowState.Normal;
                //WindowStyle = WindowStyle.None;
            }
            else if (WindowState == WindowState.Normal)
            {
                //WindowStyle = WindowStyle.SingleBorderWindow;
                WindowState = WindowState.Maximized;
                //WindowStyle = WindowStyle.None;
            }
        }

        public void Minimize()
        {
            //WindowStyle = WindowStyle.SingleBorderWindow;
            this.WindowState = WindowState.Minimized;
        }
    }
}
