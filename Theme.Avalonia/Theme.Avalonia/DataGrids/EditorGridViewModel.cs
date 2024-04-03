using System.Collections.ObjectModel;

namespace Theme.Avalonia.DataGrids
{
    public class EditorGridViewModel
    {
        public ObservableCollection<EditorItem> Items { get; }

        public EditorGridViewModel()
        {
            this.Items = new ObservableCollection<EditorItem>
            {
                new EditorItem("Item 1", false, false),
                new EditorItem("Item 2", false, false),
                new EditorItem("Item 3", true, true)
            };
        }
    }
}