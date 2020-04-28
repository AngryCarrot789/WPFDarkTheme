using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public MainViewModel()
        {
            ThemeIndex = 1;
        }

        public void SetTheme()
        {
            if (ThemeIndex == 0)
                MainWindow.SetTheme(MainWindow.Theme.Light);
            else if (ThemeIndex == 1)
                MainWindow.SetTheme(MainWindow.Theme.Dark);
        }
    }
}
