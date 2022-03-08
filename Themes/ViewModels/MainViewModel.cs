using System.Collections.ObjectModel;
using System.Net;
using System.Windows.Input;
using REghZyFramework.Utilities;
using Themes.ViewModels.DataGrids;

namespace REghZyFramework.ViewModels {
    public class MainViewModel : BaseViewModel {
        public ICommand AddContentCommand { get; set; }

        public ObservableCollection<string> SomeItems { get; }

        public DataGridViewModel DataGridViewModel { get; }

        public MainViewModel() {
            this.DataGridViewModel = new DataGridViewModel();
            this.SomeItems = new ObservableCollection<string>() {
                "1024x576",
                "1280x720",
                "1920x1080",
                "3840x2160",
            };
            this.AddContentCommand = new Command(() => {
                this.SomeItems.Add("woowowowwo1");
                this.SomeItems.Add("woowowowwo2");
                this.SomeItems.Add("woowowowwo3");
            });

            IPAddress[] addresses = Dns.GetHostAddresses("www.google.co.uk");
        }
    }
}