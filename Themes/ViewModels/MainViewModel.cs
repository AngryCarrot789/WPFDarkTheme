using REghZyFramework.Utilities;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Themes.ViewModels.DataGrids;

namespace Themes.ViewModels;

public class MainViewModel : BaseViewModel
{
    public ICommand AddContentCommand { get; set; }

    public ObservableCollection<string> SomeItems { get; }

    public DataGridViewModel DataGridViewModel { get; }
    public EditorGridViewModel EditorGridViewModel { get; }

    public MainViewModel()
    {
        DataGridViewModel = new DataGridViewModel();
        EditorGridViewModel = new EditorGridViewModel();
        SomeItems =
        [
            "1024x576",
            "1280x720",
            "1920x1080",
            "3840x2160",
        ];
        AddContentCommand = new Command(() =>
        {
            SomeItems.Add("item 1");
            SomeItems.Add("item 2");
            SomeItems.Add("item 3");
        });
    }
}