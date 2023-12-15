using System.Collections.ObjectModel;
using System.Windows;

namespace Themes.ViewModels.DataGrids;

public class EditorGridViewModel
{
    public ObservableCollection<EditorItem> Items { get; }

    public EditorGridViewModel() => Items = [
                                     new("Item 1", Visibility.Collapsed, false),
        new("Item 2", Visibility.Hidden, false),
        new("Item 3", Visibility.Visible, true)];
}