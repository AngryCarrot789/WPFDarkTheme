using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using static Themes.MainWindow;

namespace Themes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mWind = new MainWindow(this);
            mWind.Show();
        }

        public void SetTheme(Theme theme)
        {
            string themeName = null;
            switch (theme)
            {
                case Theme.Dark: themeName = "DarkTheme"; break;
                case Theme.Light: themeName = "LightTheme"; break;
            }

            if (!string.IsNullOrEmpty(themeName))
            {
                this.Resources.MergedDictionaries[0].Source = new Uri($"/ThemesFolder/{themeName}.xaml", UriKind.Relative);
            }
        }
    }
}
