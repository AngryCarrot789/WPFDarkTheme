using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace REghZyFramework.Controls {
    /// <summary>
    /// Interaction logic for LabelledItemSelector.xaml
    /// </summary>
    public partial class LabelledItemSelector : UserControl {
        public static DependencyProperty LabelTextProperty =
            DependencyProperty.Register(
                nameof(LabelText),
                typeof(string),
                typeof(LabelledItemSelector),
                new PropertyMetadata("Label Here", OnLabelTextChanged));

        public static DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(
                nameof(ItemsSource),
                typeof(ObservableCollection<string>),
                typeof(LabelledItemSelector),
                new PropertyMetadata(new ObservableCollection<string>()));

        public static DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register(
                nameof(SelectedIndex),
                typeof(int),
                typeof(LabelledItemSelector),
                new PropertyMetadata(0, OnSelectedIndexChanged));

        public static DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
                nameof(SelectedItem),
                typeof(string),
                typeof(LabelledItemSelector),
                new PropertyMetadata(string.Empty, OnSelectedItemChanged));

        public static void OnLabelTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            if (d is LabelledItemSelector control) {
                string newLabelText = (string)e.NewValue;
                control.labelText.Content = newLabelText;
            }
        }

        public static void OnSelectedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            if (d is LabelledItemSelector control) {
                int newIndex = (int)e.NewValue;
                if (control.ItemsSource != null && control.HasItems)
                    control.SelectedItem = control.ItemsSource[newIndex];
            }
        }

        public static void OnSelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            if (d is LabelledItemSelector control) {
                string newContent = (string)e.NewValue;
                control.selectedContent.Text = newContent;
            }
        }

        public string LabelText {
            get => (string) this.GetValue(LabelTextProperty);
            set => this.SetValue(LabelTextProperty, value);
        }

        public ObservableCollection<string> ItemsSource {
            get => (ObservableCollection<string>) this.GetValue(ItemsSourceProperty);
            set => this.SetValue(ItemsSourceProperty, value);
        }

        public int SelectedIndex {
            get => (int) this.GetValue(SelectedIndexProperty);
            set => this.SetValue(SelectedIndexProperty, value);
        }

        public string SelectedItem {
            get => (string) this.GetValue(SelectedItemProperty);
            set => this.SetValue(SelectedItemProperty, value);
        }

        public LabelledItemSelector() {
            this.InitializeComponent();
        }

        public void SetSelectedItem(string value) {
            this.SelectedItem = value;
        }

        public string GetPreviousItem() {
            if (this.ItemsSource != null && this.HasItems)
                if (this.HasItems && this.SelectedPosition <= this.ItemsCount)
                    return this.ItemsSource[this.SelectedIndex - 1];
            return string.Empty;
        }

        public string GetNextItem() {
            if (this.ItemsSource != null && this.HasItems)
                if (!this.IsLastItemSelected)
                    return this.ItemsSource[this.SelectedIndex + 1];
            return string.Empty;
        }

        public void ResetSelectedItem() {
            this.SelectedIndex = 0;
        }

        public bool HasItems {
            get => this.ItemsCount > 0;
        }

        public int SelectedPosition {
            get => this.SelectedIndex + 1;
        }

        public bool IsLastItemSelected {
            get => this.SelectedPosition == this.ItemsCount;
        }

        public int ItemsCount {
            get => this.ItemsSource != null ? this.ItemsSource.Count : 0;
        }

        public void MoveItemRight() {
            if (this.HasItems && this.SelectedIndex < (this.ItemsCount - 1))
                this.SelectedIndex++;
        }

        public void MoveItemLeft() {
            if (this.HasItems) {
                if (this.SelectedIndex > 0 && this.SelectedPosition <= this.ItemsSource.Count)
                    this.SelectedIndex--;
            }
        }

        private void MoveItemRightClick(object sender, RoutedEventArgs e) {
            this.MoveItemRight();
        }

        private void MoveItemLeftClick(object sender, RoutedEventArgs e) {
            this.MoveItemLeft();
        }
    }
}