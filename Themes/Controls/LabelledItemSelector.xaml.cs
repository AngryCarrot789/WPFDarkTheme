using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace REghZyFramework.Controls
{
    /// <summary>
    /// Interaction logic for LabelledItemSelector.xaml
    /// </summary>
    public partial class LabelledItemSelector : UserControl
    {
        public DependencyProperty LabelTextProperty =
            DependencyProperty.Register(
                nameof(LabelText),
                typeof(string),
                typeof(LabelledItemSelector),
                new PropertyMetadata("Label Here", OnLabelTextChanged));

        public DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(
                nameof(ItemsSource),
                typeof(ObservableCollection<string>),
                typeof(LabelledItemSelector),
                new PropertyMetadata(new ObservableCollection<string>()));

        public DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register(
                nameof(SelectedIndex),
                typeof(int),
                typeof(LabelledItemSelector),
                new PropertyMetadata(0, OnSelectedIndexChanged));

        public DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
                nameof(SelectedItem),
                typeof(string),
                typeof(LabelledItemSelector),
                new PropertyMetadata(string.Empty, OnSelectedItemChanged));

        public static void OnLabelTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not LabelledItemSelector control) return;
            
            string newLabelText = (string)e.NewValue;
            control.labelText.Content = newLabelText;
        }

        public static void OnSelectedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not LabelledItemSelector control) return;
            
            int newIndex = (int)e.NewValue;
            if (control.ItemsSource != null && control.HasItems)
                control.SelectedItem = control.ItemsSource[newIndex];
        }

        public static void OnSelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not LabelledItemSelector control) return;
            
            string newContent = (string)e.NewValue;
            control.selectedContent.Text = newContent;
        }

        public string LabelText
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }

        public ObservableCollection<string> ItemsSource
        {
            get => (ObservableCollection<string>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public int SelectedIndex
        {
            get => (int)GetValue(SelectedIndexProperty);
            set => SetValue(SelectedIndexProperty, value);
        }

        public string SelectedItem
        {
            get => (string)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public LabelledItemSelector() => InitializeComponent();

        public void SetSelectedItem(string value) => SelectedItem = value;

        public string GetPreviousItem()
        {
            if (ItemsSource != null && HasItems)
                if (HasItems && SelectedPosition <= ItemsCount)
                    return ItemsSource[SelectedIndex - 1];
            return string.Empty;
        }

        public string GetNextItem()
        {
            if (ItemsSource != null && HasItems)
                if (!IsLastItemSelected)
                    return ItemsSource[SelectedIndex + 1];
            return string.Empty;
        }

        public void ResetSelectedItem() => SelectedIndex = 0;

        public bool HasItems => ItemsCount > 0;

        public int SelectedPosition => SelectedIndex + 1;

        public bool IsLastItemSelected => SelectedPosition == ItemsCount;

        public int ItemsCount => ItemsSource != null ? ItemsSource.Count : 0;

        public void MoveItemRight()
        {
            if (HasItems && SelectedIndex < (ItemsCount - 1))
                SelectedIndex++;
        }

        public void MoveItemLeft()
        {
            if (HasItems && SelectedIndex > 0 && SelectedPosition <= ItemsSource.Count)
                    SelectedIndex--;
        }

        private void MoveItemRightClick(object sender, RoutedEventArgs e) => MoveItemRight();

        private void MoveItemLeftClick(object sender, RoutedEventArgs e) => MoveItemLeft();
    }
}