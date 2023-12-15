using REghZyFramework.Utilities;
using System.Windows;

namespace Themes.ViewModels.DataGrids;

public class EditorItem(string name, Visibility visibility, bool isEnabled) : BaseViewModel
{
    private string _name = name;
    private Visibility _visibility = visibility;
    private bool _isEnabled = isEnabled;

    public string Name
    {
        get => _name;
        set => RaisePropertyChanged(ref _name, value);
    }

    public Visibility Visibility
    {
        get => _visibility;
        set => RaisePropertyChanged(ref _visibility, value);
    }

    public bool IsEnabled
    {
        get => _isEnabled;
        set => RaisePropertyChanged(ref _isEnabled, value);
    }
}