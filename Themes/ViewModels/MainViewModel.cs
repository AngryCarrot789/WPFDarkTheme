using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Themes.Utilities;

namespace Themes.ViewModels
{
    public class DataGridItemFileExplorerSortOf
    {
        public string FileName { get; set; }
        public string DateModified { get; set; }
        public string FileType { get; set; }
        public string FileSize { get; set; }
    }

    public class MainViewModel : BaseViewModel
    {
        private int _themeIndex;
        public int ThemeIndex { get => _themeIndex; set { RaisePropertyChanged(ref _themeIndex, value); SetTheme(); } }
        public MainWindow MainWindow { get; set; }
        public MainViewModel(MainWindow mainWindow)
        {
            ThemeIndex = 1;
            MainWindow = mainWindow;
        }

        public void SetTheme()
        {
            if (MainWindow != null)
            {
                if (ThemeIndex == 0)
                    MainWindow.SetTheme(MainWindow.Theme.Light);
                else if (ThemeIndex == 1)
                    MainWindow.SetTheme(MainWindow.Theme.Dark);
            }
        }
    }
}
