using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppViewModel.Commands
{
    /// <summary>
    /// Class to initialize RoutedCommands
    /// </summary>
    public static class RoutedCommands
    {
        #region Public Static Field
        //    Window.CommandBindings>
        //    <CommandBinding Command="vm:SplashPage.StyleChange"  CanExecute="StyleCanExecute" Executed="StyleExecuted" />
        //</Window.CommandBindings>
        //public static readonly RoutedUICommand StyleChange = new RoutedUICommand("StyleChange", "StyleChange", typeof(SplashPage));
        //private void StyleCanExecute(object sender, CanExecuteRoutedEventArgs e)
        //{
        //    e.CanExecute = true;
        //}
        //private void StyleExecuted(object sender, ExecutedRoutedEventArgs e)
        //{
        //}
        /// <summary>
        /// Help Command
        /// </summary>
        public static readonly RoutedCommand HelpCommand = new RoutedCommand("HelpForward", typeof(RoutedCommands));

        /// <summary>
        /// The refresh project data command instance.
        /// </summary>
        private static readonly RoutedUICommand RefreshProjectData = new RoutedUICommand("Refresh Project Data", "RefreshProjectData", typeof(RoutedCommands));

        #endregion

        #region Public Static Property

        /// <summary>
        /// Gets the HelpCommand
        /// </summary>
        public static RoutedCommand HelpForward
        {
            get
            {
                return HelpCommand;
            }
        }

        /// <summary>
        /// Gets the refresh project data command.
        /// </summary>
        /// <value>The reset project data command.</value>
        public static RoutedUICommand RefreshProjectDataCommand
        {
            get
            {
                return RefreshProjectData;
            }
        }

        #endregion
    }
}
