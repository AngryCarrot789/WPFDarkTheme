using System.Collections.ObjectModel;

namespace Themes.ViewModels.DataGrids;

public class DataGridViewModel
{
    public ObservableCollection<ShopItem> Items { get; }

    public DataGridViewModel() => Items = [
                                  new("Xbox one", 399.99, "The old black xbox one from 2013"),
        new("PS4", 499.99, "The ps4"),
        new("AGM-183 ARRW", 15750000, "A toy for the kids")];
}