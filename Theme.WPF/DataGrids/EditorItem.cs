using System.Windows;
using Theme.WPF.MVVM;

namespace Theme.WPF.DataGrids
{
    public class EditorItem : BaseViewModel
    {
        private string name;
        private Visibility visibility;
        private bool isEnabled;

        public string Name
        {
            get => this.name;
            set => this.RaisePropertyChanged(ref this.name, value);
        }

        // Not exactly MVVM-friendly but meh.
        // Could always replace this with a bool and use a BoolToVisibility converter in the UI
        public Visibility Visibility
        {
            get => this.visibility;
            set => this.RaisePropertyChanged(ref this.visibility, value);
        }

        public bool IsEnabled
        {
            get => this.isEnabled;
            set => this.RaisePropertyChanged(ref this.isEnabled, value);
        }

        public EditorItem()
        {
        }

        public EditorItem(string name, Visibility visibility, bool isEnabled)
        {
            this.name = name;
            this.visibility = visibility;
            this.isEnabled = isEnabled;
        }
    }
}