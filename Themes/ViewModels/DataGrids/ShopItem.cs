using REghZyFramework.Utilities;

namespace Themes.ViewModels.DataGrids {
    public class ShopItem : BaseViewModel {
        private string name;
        private double price;
        private string description;

        public string Name {
            get => this.name;
            set => this.RaisePropertyChanged(ref this.name, value);
        }

        public double Price {
            get => this.price;
            set => this.RaisePropertyChanged(ref this.price, value);
        }

        public string Description {
            get => this.description;
            set => this.RaisePropertyChanged(ref this.description, value);
        }

        public ShopItem() {
        }

        public ShopItem(string name, double price, string description) {
            this.name = name;
            this.price = price;
            this.description = description;
        }
    }
}