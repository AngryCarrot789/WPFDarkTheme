using Theme.Avalonia.MVVM;

namespace Theme.Avalonia.DataGrids
{
    public class EditorItem : BaseViewModel
    {
        private string name;
        private bool isVisible;
        private bool isEnabled;

        public string Name
        {
            get => this.name;
            set => this.RaisePropertyChanged(ref this.name, value);
        }

        // Not exactly MVVM-friendly but meh.
        // Could always replace this with a bool and use a BoolToVisibility converter in the UI
        public bool IsVisible
        {
            get => this.isVisible;
            set => this.RaisePropertyChanged(ref this.isVisible, value);
        }

        public bool IsEnabled
        {
            get => this.isEnabled;
            set => this.RaisePropertyChanged(ref this.isEnabled, value);
        }

        public EditorItem()
        {
        }

        public EditorItem(string name, bool isVisible, bool isEnabled)
        {
            this.name = name;
            this.isVisible = isVisible;
            this.isEnabled = isEnabled;
        }
    }
}