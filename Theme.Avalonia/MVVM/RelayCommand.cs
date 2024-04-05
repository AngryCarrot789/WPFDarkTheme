using System;
using System.Windows.Input;

namespace Theme.Avalonia.MVVM
{
    /// <summary>
    /// An always executable command
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action _action;

        /// <summary>
        /// Creates a command that can always execute
        /// </summary>
        /// <param name="action">The method to be executed</param>
        public RelayCommand(Action action)
        {
            this._action = action;
        }

        /// <summary>
        /// Executes the command
        /// </summary>
        /// <param name="parameter">Ignored</param>
        public void Execute(object parameter)
        {
            this._action?.Invoke();
        }

        /// <summary>
        /// Returns true because this is an always executable command
        /// </summary>
        /// <param name="parameter">Ignored</param>
        /// <returns>True</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        // Since CanExecute is always true, there's no need to store event handlers that don't get fired ever
        public event EventHandler CanExecuteChanged { add { } remove { } }

        // May force the UI to re-query CanExecute can cause a button, menu, etc., to become enabled or disabled
        // public void RaiseCanExecuteChanged() {
        //     this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        // }
    }
}