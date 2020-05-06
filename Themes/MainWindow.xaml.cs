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
using Themes.ViewModels;

namespace Themes
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

            Uri iconUri = new Uri("pack://application:,,,/Resources/idektbh.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
        }

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            switch (int.Parse(((MenuItem)sender).Uid))
            {
                // light
                case 0: CurrentApplication.SetTheme(App.Theme.Light); break;
                // colourful light
                case 1: CurrentApplication.SetTheme(App.Theme.ColourfulLight); break;
                // dark
                case 2: CurrentApplication.SetTheme(App.Theme.Dark); break;
                // colourful dark
                case 3: CurrentApplication.SetTheme(App.Theme.ColourfulDark); break;
            }
            e.Handled = true;
        }
    }
}
