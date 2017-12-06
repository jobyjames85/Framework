//-----------------------------------------------------------------------------
// <copyright file="CloseMessageCommand.cs" company="ActySystem">
//     Copyright (c) Acty System India Pvt. Ltd.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace Framework.Themes.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    /// Represent CloseMessageCommand
    /// </summary>
    public static class CloseMessageCommand
    {
        #region Private Field

        /// <summary>
        /// Field for TabCloseCommand
        /// </summary>
        public static readonly RoutedCommand TabCloseCommand = new RoutedCommand("TabClose", typeof(CloseMessageCommand));

        /// <summary>
        /// Field for LogOffCommand
        /// </summary>
        public static readonly RoutedCommand LogOffCommand = new RoutedCommand("LogOff", typeof(CloseMessageCommand));

        /// <summary>
        /// Field for WindowCommand
        /// </summary>
        public static readonly RoutedCommand WindowcloseCommand = new RoutedCommand("WindowClose", typeof(CloseMessageCommand));

        /// <summary>
        /// Field for GridViewBottomCloseCommand
        /// </summary>
        public static readonly RoutedCommand GridViewBottomCloseCommand = new RoutedCommand("GridViewBottomClose", typeof(CloseMessageCommand));

        #endregion

        #region Public Property

        /// <summary>
        /// Gets the TabClose
        /// </summary>
        public static RoutedCommand TabClose
        {
            get
            {
                return TabCloseCommand; 
            }
        }

        /// <summary>
        /// Gets for LogOff
        /// </summary>
        public static RoutedCommand LogOff 
        {
            get
            {
                return LogOffCommand; 
            }
        }
        
        /// <summary>
        /// Gets for WindowClose
        /// </summary>
        public static RoutedCommand WindowClose
        {
            get
            {
                return WindowcloseCommand; 
            }
        }

        /// <summary>
        /// Gets for GridViewBottomClose
        /// </summary>
        public static RoutedCommand GridViewBottomClose 
        {
            get
            {
                return GridViewBottomCloseCommand; 
            }
        }
        #endregion
    }
}