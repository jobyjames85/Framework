using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppViewModel.Commands
{
    /// <summary>
    /// Represents the RelayCommand
    /// </summary>
    /// <typeparam name="T">The generic type parameter.</typeparam>
    public class RelayCommand<T> : ICommand
    {
        #region Field
        //private ICommand enterButton;
        //public ICommand EnterButton
        //{
        //    get
        //    {
        //        if (this.enterButton == null)
        //        {
        //            this.enterButton = new RelayCommand<object>(this.ExecuteEnter, this.CanExecuteEnter);
        //        }

        //        return this.enterButton;
        //    }
        //}
        /// <summary>
        /// Field execute
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Field canExecute
        /// </summary>
        private readonly Predicate<object> _canExecute;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand{T}"/> class
        /// </summary>
        /// <param name="execute">execute object</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand{T}"/> class
        /// </summary>
        /// <param name="execute">execute object</param>
        /// <param name="canExecute">canExecute object</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        #endregion

        #region ICommandMember

        /// <summary>
        /// ICommand Event
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// canExecute Method
        /// </summary>
        /// <param name="parameter">canExecute parameter</param>
        /// <returns>Return Parameter</returns>
        public bool CanExecute(object parameter)
        {
            return this._canExecute == null ? true : this._canExecute(parameter);
        }

        /// <summary>
        /// execute method
        /// </summary>
        /// <param name="parameter">execute parameter</param>
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }

        #endregion
    }
}
