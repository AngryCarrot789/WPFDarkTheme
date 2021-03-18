using System;
using System.Windows.Input;

namespace REghZyFramework.Utilities
{
    /// <summary>
    /// An always executable capiable of passing parameters
    /// </summary>
    /// <typeparam name="Parameter">The parameter type (<see cref="string"/>, <see cref="int"/>, etc)</typeparam>
    public class CommandParam<Parameter> : ICommand
    {
        readonly Action<Parameter> _execute;

        /// <summary>
        /// Creates a new command that can always execute
        /// </summary>
        /// <param name="execute">The method to execute</param>
        public CommandParam(Action<Parameter> execute)
        {
            if (execute == null)
                return;

            _execute = execute;
        }

        /// <summary>
        /// Executes the command only if the parameter matches the command's parameter type
        /// <para>
        ///     For example, it wont execute if the command requires a <see cref="int"/> but you provide a <see cref="string"/>
        /// </para>
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (parameter is Parameter p)
                _execute?.Invoke(p);
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

        public event EventHandler CanExecuteChanged
        {
            add { } remove { }
            //add { CommandManager.RequerySuggested += value; }
            //remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
