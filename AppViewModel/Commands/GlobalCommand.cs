using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AppViewModel.Commands
{
    /// <summary>
    /// Represents the WindowCommands
    /// </summary>
    public class WindowCommands : FrameworkElement
    {
        #region Public static method
         //Command="CommandClass:RoutedCommands.HelpForward"
        /// <summary>
        /// Register All Command 
        /// </summary>
        public static void RegisterAllCommands()
        {
            RegisterHelp();

            RegisterCommandBinding(RoutedCommands.RefreshProjectDataCommand, OnRefreshProjectData, CanProjectActionExecute);
        }

        /// <summary>
        /// Register Help Command
        /// </summary>
        private static void RegisterHelp()
        {
            CommandManager.RegisterClassCommandBinding(
                typeof(Button),
                new CommandBinding(
                    RoutedCommands.HelpForward,
                    delegate(object d, ExecutedRoutedEventArgs e)
                    {
                        Button helpCommand = d as Button;
                        if (helpCommand != null)
                        {
                            //Help help = new Help();
                            //help.Owner = App.Current.MainWindow;
                            //help.ShowDialog();
                        }
                    },
            delegate(object d, CanExecuteRoutedEventArgs e)
            {
                e.CanExecute = true;
            }));
        }

        /// <summary>
        /// Registers the command binding.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="canExecute">The can execute.</param>
        /// <param name="keyBinding">The key binding.</param>
        private static void RegisterCommandBinding(ICommand command, ExecutedRoutedEventHandler handler, CanExecuteRoutedEventHandler canExecute = null, KeyGesture keyBinding = null)
        {
            RegisterCommandBinding(new CommandBinding(command, handler, canExecute));
        }

        /// <summary>
        /// Registers the command binding.
        /// </summary>
        /// <param name="commandBinding">The command binding.</param>
        private static void RegisterCommandBinding(CommandBinding commandBinding)
        {
            Application.Current.MainWindow.CommandBindings.Add(commandBinding);
        }

        /// <summary>
        /// Resets the project.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Input.ExecutedRoutedEventArgs"/> instance containing the event data.</param>
        private static void OnRefreshProjectData(object sender, ExecutedRoutedEventArgs e)
        {
        }

        /// <summary>
        /// Determines whether this instance [can project action execute].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Input.CanExecuteRoutedEventArgs"/> instance containing the event data.</param>
        private static void CanProjectActionExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        #endregion
    }
}
