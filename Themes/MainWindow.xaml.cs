using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using FramePFX.Themes;
using REghZyFramework.ViewModels;

namespace REghZyFramework {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public App CurrentApplication { get; set; }

        public MainWindow() {
            this.InitializeComponent();
            this.DataContext = new MainViewModel();

            // loads a png icon, not an ico. 
            Uri iconUri = new Uri("pack://application:,,,/Resources/idektbh.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
        }

        private void ChangeTheme(object sender, RoutedEventArgs e) {
            switch (((MenuItem) sender).Uid) {
                case "0": ThemesController.SetTheme(ThemeType.DeepDark); break;
                case "1": ThemesController.SetTheme(ThemeType.SoftDark); break;
                case "2": ThemesController.SetTheme(ThemeType.DarkGreyTheme); break;
                case "3": ThemesController.SetTheme(ThemeType.GreyTheme); break;
                case "4": ThemesController.SetTheme(ThemeType.LightTheme); break;
                case "5": ThemesController.SetTheme(ThemeType.RedBlackTheme); break;
            }

            e.Handled = true;
        }
    }
}