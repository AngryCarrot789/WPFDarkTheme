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
        public ICommand CloseWindowCommand     { get; set; }
        public ICommand MaximizeRestoreCommand { get; set; }
        public ICommand MinimizeWindowCommand  { get; set; }

        private void CloseWindow() { (Application.Current.MainWindow as MainWindow).CloseWindow(); }
        private void MaximRestre() { (Application.Current.MainWindow as MainWindow).MaximizeRestore(); }
        private void MinimWindow() { (Application.Current.MainWindow as MainWindow).Minimize(); }

        private int _themeIndex;
        public int ThemeIndex { get => _themeIndex; set { RaisePropertyChanged(ref _themeIndex, value); SetTheme(); } }

        private ObservableCollection<DataGridItemFileExplorerSortOf> items = new ObservableCollection<DataGridItemFileExplorerSortOf>();
        public ObservableCollection<DataGridItemFileExplorerSortOf> DataGridItems
        {
            get => items;
            set => RaisePropertyChanged(ref items, value);
        }

        public MainViewModel()
        {
            DataGridItems.Add(new DataGridItemFileExplorerSortOf() { FileName = "testfile.png", DateModified = "25/12/1924", FileSize = "106 GB", FileType = "PNG File" });
            DataGridItems.Add(new DataGridItemFileExplorerSortOf() { FileName = "eeee.txt", DateModified = "25/12/1924", FileSize = "20 GB", FileType = "txt File" });
            DataGridItems.Add(new DataGridItemFileExplorerSortOf() { FileName = "t2222.png", DateModified = "25/12/1911", FileSize = "40 GB", FileType = "PNG File" });
            DataGridItems.Add(new DataGridItemFileExplorerSortOf() { FileName = "t3333png", DateModified = "25/12/1928", FileSize = "2 GB", FileType = "PNG File" });
            DataGridItems.Add(new DataGridItemFileExplorerSortOf() { FileName = "34445tpng", DateModified = "25/12/1925", FileSize = "67 GB", FileType = "PNG File" });
            DataGridItems.Add(new DataGridItemFileExplorerSortOf() { FileName = "t5657png", DateModified = "25/12/1224", FileSize = "62244 GB", FileType = "idkfile" });
            DataGridItems.Add(new DataGridItemFileExplorerSortOf() { FileName = "tp67u67ng.txt", DateModified = "25/12/2124", FileSize = "455 GB", FileType = "txt File" });

            CloseWindowCommand = new Command(CloseWindow);
            MaximizeRestoreCommand = new Command(MaximRestre);
            MinimizeWindowCommand = new Command(MinimWindow);
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
