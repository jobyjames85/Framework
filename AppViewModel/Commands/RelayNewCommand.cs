using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppViewModel.Commands
{
    /// <summary>
    /// A command whose sole purpose is to relay its functionality to other objects by invoking delegates. The default return value for the CanExecute method is 'true'.
    /// </summary>
    public class RelayNewCommand : ICommand
    {
        #region Declarations

        /// <summary>
        /// Field for _canExecute
        /// </summary>
        private readonly Func<bool> _canExecute;

        /// <summary>
        /// Field for _execute
        /// </summary>
        private readonly Action _execute;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayNewCommand"/> class and the command can always be executed.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        public RelayNewCommand(Action execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayNewCommand"/> class.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayNewCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            this._execute = execute;
            this._canExecute = canExecute;
        }

        #endregion

        #region ICommand Members
        /// <summary>
        /// ICommand Event
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (this._canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }

            remove
            {
                if (this._canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

        /// <summary>
        /// CanExecute Method
        /// </summary>
        /// <param name="parameter">Object parameter</param>
        /// <returns>Return Parameter</returns>
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return this._canExecute == null ? true : this._canExecute();
        }

        /// <summary>
        /// Execute Method
        /// </summary>
        /// <param name="parameter">Object parameter</param>
        public void Execute(object parameter)
        {
            this._execute();
        }

        #endregion
    }
}
