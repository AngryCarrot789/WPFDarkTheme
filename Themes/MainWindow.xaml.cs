using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using REghZyFramework.ViewModels;
using REghZyFramework.Themes;

namespace REghZyFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public App CurrentApplication { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

            // loads a png icon, not an ico. 
            Uri iconUri = new Uri("pack://application:,,,/Resources/idektbh.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
        }

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            switch (int.Parse(((MenuItem)sender).Uid))
            {
                case 0: ThemesController.SetTheme(ThemesController.ThemeTypes.Light); break;
                case 1: ThemesController.SetTheme(ThemesController.ThemeTypes.ColourfulLight); break;
                case 2: ThemesController.SetTheme(ThemesController.ThemeTypes.Dark); break;
                case 3: ThemesController.SetTheme(ThemesController.ThemeTypes.ColourfulDark); break;
            }
            e.Handled = true;
        }
    }
}
