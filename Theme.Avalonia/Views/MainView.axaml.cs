using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Theme.Avalonia.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        this.InitializeComponent();
    }

    private void ChangeTheme(object? sender, RoutedEventArgs e)
    {
        // switch (((MenuItem) sender).DataContext)
        // {
        //     case "0": ThemesController.SetTheme(ThemeType.DeepDark); break;
        //     case "1": ThemesController.SetTheme(ThemeType.SoftDark); break;
        //     case "2": ThemesController.SetTheme(ThemeType.DarkGreyTheme); break;
        //     case "3": ThemesController.SetTheme(ThemeType.GreyTheme); break;
        //     case "4": ThemesController.SetTheme(ThemeType.LightTheme); break;
        //     case "5": ThemesController.SetTheme(ThemeType.RedBlackTheme); break;
        // }
        // 
        // e.Handled = true;
    }
}