using System.Collections.ObjectModel;
using System.Windows.Input;
using Theme.Avalonia.DataGrids;
using Theme.Avalonia.MVVM;

namespace Theme.Avalonia;

public class MainViewModel : BaseViewModel
{
    public DataGridViewModel DataGridViewModel { get; }

    public EditorGridViewModel EditorGridViewModel { get; }

    public ObservableCollection<string> SomeItems { get; }

    public ICommand AddContentCommand { get; set; }

    public MainViewModel()
    {
        this.DataGridViewModel = new DataGridViewModel();
        this.EditorGridViewModel = new EditorGridViewModel();
        this.SomeItems = new ObservableCollection<string>()
        {
            "1024x576",
            "1280x720",
            "1920x1080",
            "3840x2160",
        };

        this.AddContentCommand = new RelayCommand(() =>
        {
            this.SomeItems.Add("item 1");
            this.SomeItems.Add("item 2");
            this.SomeItems.Add("item 3");
        });
    }
}