using System.Collections.ObjectModel;
using System.Windows.Input;
using REghZyFramework.Utilities;
using Themes.ViewModels.DataGrids;

namespace Themes.ViewModels {
    public class MainViewModel : BaseViewModel {
        public ICommand AddContentCommand { get; set; }

        public ObservableCollection<string> SomeItems { get; }

        public DataGridViewModel DataGridViewModel { get; }
        public EditorGridViewModel EditorGridViewModel { get; }

        public MainViewModel() {
            this.DataGridViewModel = new DataGridViewModel();
            this.EditorGridViewModel = new EditorGridViewModel();
            this.SomeItems = new ObservableCollection<string>() {
                "1024x576",
                "1280x720",
                "1920x1080",
                "3840x2160",
            };
            this.AddContentCommand = new Command(() => {
                this.SomeItems.Add("item 1");
                this.SomeItems.Add("item 2");
                this.SomeItems.Add("item 3");
            });
        }
    }
}