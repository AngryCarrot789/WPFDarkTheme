using REghZyFramework.Utilities;

namespace Themes.ViewModels.DataGrids {
    public class ShopItem : BaseViewModel {
        private string _name;
        private double _price;
        private string _description;

        public string Name {
            get => this._name;
            set => RaisePropertyChanged(ref this._name, value);
        }

        public double Price {
            get => this._price;
            set => RaisePropertyChanged(ref this._price, value);
        }

        public string Description {
            get => this._description;
            set => RaisePropertyChanged(ref this._description, value);
        }
    }
}