using System.Collections.ObjectModel;

namespace Themes.ViewModels.DataGrids {
    public class DataGridViewModel {
        public ObservableCollection<ShopItem> Items { get; }

        public DataGridViewModel() {
            this.Items = new ObservableCollection<ShopItem> {
                new ShopItem() {
                    Name = "Xbox one", Price = 399.99, Description = "The old black xbox one from 2013 :)"
                },
                new ShopItem() {
                    Name = "PS4", Price = 499.99, Description = "The ps4 :))"
                },
                new ShopItem() {
                    Name = "AGM-183 ARRW", Price = 137500000, Description = "thign" //Hypersonic air-launched rapid response air-to-ground missile lol"
                }
            };
        }
    }
}