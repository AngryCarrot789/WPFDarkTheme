using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Themes.Utilities
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //this is the old one. it's meh. you have to manually set private fields in the get set bit, whereas
        //the new version you just reference the private one and it does it for you
        //public void RaisePropertyChanged([CallerMemberName] string propName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        //}

        /// <summary>
        /// Does the raisepropertychanged thingy, and also sets the private fields for you. much easier.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property">the private field that is used for "setting"</param>
        /// <param name="value">the new value of this property</param>
        /// <param name="propertyName">dont need to specify this usually, but the name of the property/field</param>
        public void RaisePropertyChanged<T>(ref T property, T value, [CallerMemberName] string propertyName = "")
        {
            property = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
