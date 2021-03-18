using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace REghZyFramework.Utilities
{
    /// <summary>
    /// <para>
    ///     An abstract class that implements <see cref="INotifyPropertyChanged"/>, allowing data binding between a ViewModel and a View 
    ///     along with some helper function to, for example, run an <see cref="Action"/> before or after the PropertyRaised event has been risen
    /// </para>
    /// <para>
    ///     This class should normally be inherited by a ViewModel, such as a MainViewModel for the main view
    /// </para>
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises a propertychanged event, allowing the view to be updated. Pass in your private property, new value, 
        /// can also pass the property name but that's done for you.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property">the private field that is used for "setting"</param>
        /// <param name="newValue">the new value of this property</param>
        /// <param name="propertyName">dont need to specify this, but the name of the property/field</param>
        public void RaisePropertyChanged<T>(ref T property, T newValue, [CallerMemberName] string propertyName = "")
        {
            property = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Raises a propertychanged event, allowing the view to be updated. Pass in a reference to your private property, specify the new value,
        /// and a callback method (if you want to). Can also pass the property name but that's done for you
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property">the private field that is used for "setting"</param>
        /// <param name="value">the new value of this property</param>
        /// <param name="propertyName">dont need to specify this usually, but the name of the property/field</param>
        /// <param name="callbackMethod">the method that gets called after property changed</param>
        /// <param name="callsAfterPropertyChanged">If true, the callback function runs after the property change event is called. Otherwise it's called before </param>
        public void RaisePropertyChanged<T>(ref T property, T newValue, Action callbackMethod, bool callbackAfterPropChanged = true, [CallerMemberName] string propertyName = "")
        {
            if (!callbackAfterPropChanged)
            {
                callbackMethod?.Invoke();
            }
            RaisePropertyChanged(ref property, newValue, propertyName);
            if (callbackAfterPropChanged)
            {
                callbackMethod?.Invoke();
            }
        }

        /// <summary>
        /// Raises a propertychanged event, allowing the view to be updated. Pass in your private property, new value,
        /// and a callback method containing the new value as a param if you want, can also pass the property name but that's done for you.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property">the private field that is used for "setting"</param>
        /// <param name="newValue">the new value of this property</param>
        /// <param name="propertyName">dont need to specify this usually, but the name of the property/field</param>
        /// <param name="callbackMethod">The method that gets called after property changed, and contains the new value as a parameter</param>
        /// <param name="callbackAfterPropChanged">If true, the callback function runs after the property change event is called. Otherwise it's called before </param>
        public void RaisePropertyChanged<T>(ref T property, T newValue, Action<T> callbackMethod, bool callbackAfterPropChanged = true, [CallerMemberName] string propertyName = "")
        {
            if (!callbackAfterPropChanged)
            {
                callbackMethod?.Invoke(newValue);
            }
            RaisePropertyChanged(ref property, newValue, propertyName);
            if (callbackAfterPropChanged)
            {
                callbackMethod?.Invoke(newValue);
            }
        }
    }
}
