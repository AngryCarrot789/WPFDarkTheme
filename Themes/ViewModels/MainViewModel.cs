using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using REghZyFramework.Utilities;

namespace REghZyFramework.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand owo { get; set; }

        public ObservableCollection<string> SomeItems
        {
            get;set;
        }

        public MainViewModel()
        {
            SomeItems = new ObservableCollection<string>()
            {
                "1024x576",
                "1280x720",
                "1920x1080",
                "3840x2160",
            };
            owo = new Command(() =>
            {
                SomeItems.Add("woowowowwo1");
                SomeItems.Add("woowowowwo2");
                SomeItems.Add("woowowowwo3");
            });
        }
    }
}
