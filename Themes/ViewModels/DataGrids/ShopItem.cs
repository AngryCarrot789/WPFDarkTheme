using REghZyFramework.Utilities;

namespace Themes.ViewModels.DataGrids;

public class ShopItem(string name, double price, string description) : BaseViewModel
{
    private string _name = name;
    private double _price = price;
    private string _description = description;

    public string Name
    {
        get => _name;
        set => RaisePropertyChanged(ref this._name, value);
    }

    public double Price
    {
        get => _price;
        set => RaisePropertyChanged(ref this._price, value);
    }

    public string Description
    {
        get => _description;
        set => RaisePropertyChanged(ref this._description, value);
    }
}