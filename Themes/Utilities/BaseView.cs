namespace REghZyFramework.Utilities
{
    /// <summary>
    ///     An interface that all views or controls could implement for easy 
    ///     access to their ViewModel. Not nessesary in most cases though
    /// </summary>
    /// <typeparam name="ViewModel">The ViewModel class that implements <see cref="BaseViewModel"/></typeparam>
    public interface BaseView<ViewModel> where ViewModel : BaseViewModel
    {
        ViewModel Model { get; set; }
    }
}
