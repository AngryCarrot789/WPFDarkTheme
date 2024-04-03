using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace Theme.WPF.Controls
{
    // It would be a better idea to make this a Control, and create a style somewhere (e.g. App.xaml),
    // since that will yield faster application runtime, since a UserControl loads the xaml each time
    // an instance is created due to InitializeComponent
    public partial class LabelledItemSelector : UserControl
    {
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register(
                nameof(LabelText),
                typeof(string),
                typeof(LabelledItemSelector),
                new PropertyMetadata("Label Here", OnLabelTextChanged));

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(
                nameof(ItemsSource),
                typeof(IList),
                typeof(LabelledItemSelector),
                new PropertyMetadata(null, OnItemsSourceChanged));

        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register(
                nameof(SelectedIndex),
                typeof(int),
                typeof(LabelledItemSelector),
                new PropertyMetadata(0, OnSelectedIndexChanged));

        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
                nameof(SelectedItem),
                typeof(object),
                typeof(LabelledItemSelector),
                new PropertyMetadata(string.Empty, OnSelectedItemChanged));

        public string LabelText
        {
            get => (string) this.GetValue(LabelTextProperty);
            set => this.SetValue(LabelTextProperty, value);
        }

        public IList ItemsSource
        {
            get => (IList) this.GetValue(ItemsSourceProperty);
            set => this.SetValue(ItemsSourceProperty, value);
        }

        public int SelectedIndex
        {
            get => (int) this.GetValue(SelectedIndexProperty);
            set => this.SetValue(SelectedIndexProperty, value);
        }

        public object SelectedItem
        {
            get => this.GetValue(SelectedItemProperty);
            set => this.SetValue(SelectedItemProperty, value);
        }

        public bool HasItems
        {
            get => this.ItemsCount > 0;
        }

        public int SelectedPosition
        {
            get => this.SelectedIndex + 1;
        }

        public bool IsLastItemSelected
        {
            get => this.SelectedPosition == this.ItemsCount;
        }

        public int ItemsCount
        {
            get => this.ItemsSource != null ? this.ItemsSource.Count : 0;
        }

        public LabelledItemSelector()
        {
            this.InitializeComponent();
        }

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is IList collection)
            {
                ((LabelledItemSelector) d).SelectedIndex = collection.Count > 0 ? (collection.Count - 1) : -1;
            }
        }

        private static void OnLabelTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is LabelledItemSelector control)
            {
                string newLabelText = (string) e.NewValue;
                control.labelText.Content = newLabelText;
            }
        }

        private static void OnSelectedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is LabelledItemSelector control)
            {
                int newIndex = (int) e.NewValue;
                if (control.ItemsSource != null && control.HasItems)
                    control.SelectedItem = control.ItemsSource[newIndex];
            }
        }

        private static void OnSelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is LabelledItemSelector control)
            {
                string newContent = (string) e.NewValue;
                control.selectedContent.Text = newContent;
            }
        }

        public void ResetSelectedItem() => this.SelectedIndex = 0;

        public void MoveItemRight()
        {
            if (this.HasItems && this.SelectedIndex < (this.ItemsCount - 1))
                this.SelectedIndex++;
        }

        public void MoveItemLeft()
        {
            if (this.HasItems)
            {
                if (this.SelectedIndex > 0 && this.SelectedPosition <= this.ItemsSource.Count)
                    this.SelectedIndex--;
            }
        }

        private void MoveItemRightClick(object sender, RoutedEventArgs e)
        {
            this.MoveItemRight();
        }

        private void MoveItemLeftClick(object sender, RoutedEventArgs e)
        {
            this.MoveItemLeft();
        }
    }
}