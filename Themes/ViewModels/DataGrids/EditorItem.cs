using System.Windows;
using REghZyFramework.Utilities;

namespace Themes.ViewModels.DataGrids {
    public class EditorItem : BaseViewModel {
        private string name;
        private Visibility visibility;
        private bool isEnabled;

        public string Name {
            get => this.name;
            set => this.RaisePropertyChanged(ref this.name, value);
        }

        public Visibility Visibility {
            get => this.visibility;
            set => this.RaisePropertyChanged(ref this.visibility, value);
        }

        public bool IsEnabled {
            get => this.isEnabled;
            set => this.RaisePropertyChanged(ref this.isEnabled, value);
        }

        public EditorItem() {
        }

        public EditorItem(string name, Visibility visibility, bool isEnabled) {
            this.name = name;
            this.visibility = visibility;
            this.isEnabled = isEnabled;
        }
    }
}