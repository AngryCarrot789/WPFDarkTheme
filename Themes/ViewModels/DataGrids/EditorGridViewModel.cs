using System.Collections.ObjectModel;
using System.Windows;

namespace Themes.ViewModels.DataGrids {
    public class EditorGridViewModel {
        public ObservableCollection<EditorItem> Items { get; }

        public EditorGridViewModel() {
            this.Items = new ObservableCollection<EditorItem> {
                new EditorItem("Item 1", Visibility.Collapsed, false),
                new EditorItem("Item 2", Visibility.Hidden, false),
                new EditorItem("Item 3", Visibility.Visible, true)
            };
        }
    }
}
