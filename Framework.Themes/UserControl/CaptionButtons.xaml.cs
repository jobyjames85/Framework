//-----------------------------------------------------------------------------
// <copyright file="CaptionButtons.xaml.cs" company="ActySystem">
//     Copyright (c) Acty System India Pvt. Ltd.  All rights reserved.
// </copyright>
//----------------------------------------------------------------------------

namespace Framework.Themes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for CaptionButtons
    /// </summary>
    public partial class CaptionButtons : UserControl
    {
        #region Private Property

        /// <summary>
        /// Field the IsMinimizeVisible
        /// </summary>
        public static readonly DependencyProperty IsMinimizeVisibleProperty = DependencyProperty.Register("IsMinimizeVisible", typeof(bool), typeof(CaptionButtons), new UIPropertyMetadata(true, MinimizeVisbileChanged));

        /// <summary>
        /// Field the IsMaximizeVisible
        /// </summary>
        public static readonly DependencyProperty IsMaximizeVisibleProperty = DependencyProperty.Register("IsMaximizeVisible", typeof(bool), typeof(CaptionButtons), new UIPropertyMetadata(true, MaximizeVisbileChanged));

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionButtons"/> class.
        /// </summary>
        public CaptionButtons()
        {
            this.InitializeComponent();
        }

        #region Public Property

        /// <summary>
        /// Gets or sets a value indicating whether the IsMaximizeVisible
        /// </summary>
        public bool IsMaximizeVisible
        {
            get { return (bool)GetValue(IsMaximizeVisibleProperty); }
            set { this.SetValue(IsMaximizeVisibleProperty, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the IsMinimizeVisible
        /// </summary>
        public bool IsMinimizeVisible
        {
            get { return (bool)GetValue(IsMinimizeVisibleProperty); }
            set { this.SetValue(IsMinimizeVisibleProperty, value); }
        }

        #endregion

        /// <summary>
        /// Minimize Changed Method
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        protected static void MinimizeVisbileChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var captionButtons = sender as CaptionButtons;
            if (null != captionButtons)
            {
                if (!(bool)e.NewValue)
                {
                    captionButtons.btnSysMinimize.Visibility = Visibility.Collapsed;
                }
            }
        }

        /// <summary>
        /// Maximize Method
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        protected static void MaximizeVisbileChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var captionButtons = sender as CaptionButtons;
            if (null != captionButtons)
            {
                if (!(bool)e.NewValue)
                {
                    captionButtons.btnSysMaximize.Visibility = Visibility.Collapsed;
                }
            }
        }

        /// <summary>
        /// Close Command
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void CloseCommand(object sender, ExecutedRoutedEventArgs e)
        {
            //// SystemCommands.CloseWindow(Window.GetWindow(this));         
            ////ActySystem.Telas.Themes.CloseMessageCommand.WindowClose.Execute(null, null);
            Application.Current.MainWindow.Close();
        }

        /// <summary>
        /// maximizeWindow Executed
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Event Parameter</param>
        private void MaximizeWindow_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Window wnd = Window.GetWindow(this);
            if (wnd.WindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow(wnd);
            }
            else
            {
                SystemCommands.MaximizeWindow(wnd);
            }
        }

        /// <summary>
        /// minimizeWindow Executed
        /// </summary>
        /// <param name="sender">sender parameter</param>
        /// <param name="e">Event Parameter</param>
        private void MinimizeWindow_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(Window.GetWindow(this));
        }
    }
}
