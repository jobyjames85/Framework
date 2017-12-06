using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Framework.devControls.CustomControl
{
    /// <summary>
    /// Interaction logic for PopupMessageBox
    /// </summary>
    public partial class PopupMessageBox : INotifyPropertyChanged
    {
        #region Private Field

        /// <summary>
        /// Field this._animationRan
        /// </summary>
        private bool _animationRan;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PopupMessageBox"/> class.
        /// </summary>
        /// <param name="owner">Owner Window</param>
        /// <param name="message">Message Value</param>
        /// <param name="details">Details Message</param>
        /// <param name="button">Button Type</param>
        /// <param name="icon">Message Icon</param>
        /// <param name="defaultResult">Default Result</param>
        /// <param name="options">Options Message</param>
        public PopupMessageBox(Window owner, string message, string details, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            this._animationRan = false;

            this.InitializeComponent();

            Owner = owner ?? Application.Current.MainWindow;

            this.CreateButtons(button, defaultResult);

            this.CreateImage(icon);

            MessageText.Text = message;

            this.ApplyOptions(options);
        }

        #endregion

        #region Event Property

        /// <summary>
        /// public Property Change Event 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Public Property

        /// <summary>
        ///  Gets or sets the MessageBox Result
        /// </summary>
        public MessageBoxResult MessageBoxResult { get; set; }

        #endregion

        #region Public Static Method

        /// <summary>
        /// Display an information message
        /// </summary>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="showCancel">Display cancel</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowInformation(string message, string details = "", bool showCancel = false, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return ShowInformation(null, message, details, showCancel, options);
        }

        /// <summary>
        /// Display an information message
        /// </summary>
        /// <param name="owner">The message box's parent window</param>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="showCancel">Display the cancel</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowInformation(Window owner, string message, string details = "", bool showCancel = false, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return Show(owner, message, details, showCancel ? MessageBoxButton.OKCancel : MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK, options);
        }

        /// <summary>
        /// Display a question
        /// </summary>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="showCancel">Display the cancel</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowQuestion(string message, string details = "", bool showCancel = false, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return ShowQuestion(null, message, details, showCancel, options);
        }

        /// <summary>
        /// Display a question
        /// </summary>
        /// <param name="owner">The message box's parent window</param>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="showCancel">Display the cancel</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowQuestion(Window owner, string message, string details = "", bool showCancel = false, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return Show(owner, message, details, showCancel ? MessageBoxButton.YesNoCancel : MessageBoxButton.YesNo, MessageBoxImage.None, MessageBoxResult.Yes, options);
        }

        /// <summary>
        /// Display a warning
        /// </summary>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="showCancel">Display the cancel</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowWarning(string message, string details = "", bool showCancel = false, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return ShowWarning(null, message, details, showCancel, options);
        }

        /// <summary>
        /// Display a warning
        /// </summary>
        /// <param name="owner">The message box's parent window</param>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="showCancel">Display the cancel</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowWarning(Window owner, string message, string details = "", bool showCancel = false, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return Show(owner, message, details, showCancel ? MessageBoxButton.OKCancel : MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, options);
        }

        /// <summary>
        /// Display an Error
        /// </summary>
        /// <param name="exception">Display the exception's details</param>
        /// <param name="message">The message text</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowError(Exception exception, string message = "", MessageBoxOptions options = MessageBoxOptions.None)
        {
            return ShowError(null, exception, message, options);
        }

        /// <summary>
        /// Display an Error
        /// </summary>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="showCancel">Display the cancel</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowError(string message, string details = "", bool showCancel = false, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return ShowError(null, message, details, showCancel, options);
        }

        /// <summary>
        /// Display an Error
        /// </summary>
        /// <param name="owner">The message box's parent window</param>
        /// <param name="exception">Display the exception's details</param>
        /// <param name="message">The message text</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowError(Window owner, Exception exception, string message = "", MessageBoxOptions options = MessageBoxOptions.None)
        {
            string details = string.Empty;
#if DEBUG
            details = exception.ToString();
#endif
            return Show(owner, string.IsNullOrEmpty(message) ? exception.Message : message, details, MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, options);
        }

        /// <summary>
        /// Display an Error
        /// </summary>
        /// <param name="owner">The message box's parent window</param>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="showCancel">Display the cancel</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult ShowError(Window owner, string message, string details = "", bool showCancel = false, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return Show(owner, message, details, showCancel ? MessageBoxButton.OKCancel : MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, options);
        }

        /// <summary>
        /// Show the message box with the specified parameters
        /// </summary>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="button">The buttons to be displayed</param>
        /// <param name="icon">The message's severity</param>
        /// <param name="defaultResult">The default button</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult Show(string message, string details = "", MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.None, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return Show(null, message, details, button, icon, defaultResult, options);
        }

        /// <summary>
        /// Show the message box with the specified parameters
        /// </summary>
        /// <param name="message">The message text</param>
        /// <param name="button">The buttons to be displayed</param>
        /// <param name="icon">The message's severity</param>
        /// <param name="defaultResult">The default button</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult Show(string message, MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.None, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return Show(message, string.Empty, button, icon, defaultResult, options);
        }

        /// <summary>
        /// Show the message box with the specified parameters
        /// </summary>
        /// <param name="owner">The message box's parent window</param>
        /// <param name="message">The message text</param>
        /// <param name="button">The buttons to be displayed</param>
        /// <param name="icon">The message's severity</param>
        /// <param name="defaultResult">The default button</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult Show(Window owner, string message, MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.None, MessageBoxOptions options = MessageBoxOptions.None)
        {
            return Show(owner, message, string.Empty, button, icon, defaultResult, options);
        }

        /// <summary>
        /// Show the message box with the specified parameters
        /// </summary>
        /// <param name="owner">The message box's parent window</param>
        /// <param name="message">The message text</param>
        /// <param name="details">The details part text</param>
        /// <param name="button">The buttons to be displayed</param>
        /// <param name="icon">The message's severity</param>
        /// <param name="defaultResult">The default button</param>
        /// <param name="options">Message options</param>
        /// <returns>The user's selected button</returns>
        public static MessageBoxResult Show(Window owner, string message, string details = "", MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.None, MessageBoxOptions options = MessageBoxOptions.None)
        {
            MessageBoxResult result = MessageBoxResult.None;
            result = Application.Current.Dispatcher.Invoke(new Func<MessageBoxResult>(() =>
            {
                var messageBox = new PopupMessageBox(owner, message, details, button, icon, defaultResult, options);

                messageBox.ShowDialog();

                return messageBox.MessageBoxResult;
            }));

            if (result != MessageBoxResult.None)
            {
                return (MessageBoxResult)result;
            }
            else
            {
                return MessageBoxResult.None;
            }
        }

        #endregion

        #region Public Method

        /// <summary>
        /// Property Change Event
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler temp = this.PropertyChanged;
            if (temp != null)
            {
                temp(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Private Method

        /// <summary>
        /// Create the message box's button according to the user's demand
        /// </summary>
        /// <param name="button">The user's buttons selection</param>
        /// <param name="defaultResult">The default button</param>
        private void CreateButtons(MessageBoxButton button, MessageBoxResult defaultResult)
        {
            switch (button)
            {
                case MessageBoxButton.OK:
                    ButtonsPanel.Children.Add(this.CreateOkButton(defaultResult));
                    break;
                case MessageBoxButton.OKCancel:
                    ButtonsPanel.Children.Add(this.CreateOkButton(defaultResult));
                    ButtonsPanel.Children.Add(this.CreateCancelButton(defaultResult));
                    break;
                case MessageBoxButton.YesNoCancel:
                    ButtonsPanel.Children.Add(this.CreateYesButton(defaultResult));
                    ButtonsPanel.Children.Add(this.CreateNoButton(defaultResult));
                    ButtonsPanel.Children.Add(this.CreateCancelButton(defaultResult));
                    break;
                case MessageBoxButton.YesNo:
                    ButtonsPanel.Children.Add(this.CreateYesButton(defaultResult));
                    ButtonsPanel.Children.Add(this.CreateNoButton(defaultResult));
                    break;
                default:
                    throw new ArgumentOutOfRangeException("button");
            }
        }

        /// <summary>
        /// Create the ok button on demand
        /// </summary>
        /// <param name="defaultResult">MessageBox Result</param>
        /// <returns>Return Value</returns>
        private Button CreateOkButton(MessageBoxResult defaultResult)
        {
            var okButton = new Button
            {
                Name = "okButton",
                Content = "OK",
                IsDefault = defaultResult == MessageBoxResult.OK,
                Tag = MessageBoxResult.OK,
            };

            okButton.Click += this.ButtonClick;

            return okButton;
        }

        /// <summary>
        /// Create the cancel button on demand
        /// </summary>
        /// <param name="defaultResult">MessageBox Result</param>
        /// <returns>Return Value</returns>
        private Button CreateCancelButton(MessageBoxResult defaultResult)
        {
            var cancelButton = new Button
            {
                Name = "cancelButton",
                Content = "Cancel",
                IsDefault = defaultResult == MessageBoxResult.Cancel,
                IsCancel = true,
                Tag = MessageBoxResult.Cancel,
            };

            cancelButton.Click += this.ButtonClick;

            return cancelButton;
        }

        /// <summary>
        /// Create the yes button on demand
        /// </summary>
        /// <param name="defaultResult">MessageBox Result</param>
        /// <returns>Return Value</returns>
        private Button CreateYesButton(MessageBoxResult defaultResult)
        {
            var yesButton = new Button
            {
                Name = "yesButton",
                Content = "Yes",
                IsDefault = defaultResult == MessageBoxResult.Yes,
                Tag = MessageBoxResult.Yes,
            };

            yesButton.Click += this.ButtonClick;

            return yesButton;
        }

        /// <summary>
        /// Create the no button on demand
        /// </summary>
        /// <param name="defaultResult">MessageBox Result</param>
        /// <returns>Return Value</returns>
        private Button CreateNoButton(MessageBoxResult defaultResult)
        {
            var noButton = new Button
            {
                Name = "noButton",
                Content = "No",
                IsDefault = defaultResult == MessageBoxResult.No,
                Tag = MessageBoxResult.No,
            };

            noButton.Click += this.ButtonClick;

            return noButton;
        }

        /// <summary>
        /// The event the buttons trigger. 
        /// Each button hold it's result in the tag, so here it just sets them and close the message box.
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Argument Parameter</param>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult = (MessageBoxResult)(sender as Button).Tag;

            Close();
        }

        /// <summary>
        /// MessageBox Method
        /// </summary>
        /// <param name="options">Message Box option</param>
        private void ApplyOptions(MessageBoxOptions options)
        {
            if ((options & MessageBoxOptions.RightAlign) == MessageBoxOptions.RightAlign)
            {
                MessageText.TextAlignment = TextAlignment.Right;
            }

            if ((options & MessageBoxOptions.RtlReading) == MessageBoxOptions.RtlReading)
            {
                FlowDirection = FlowDirection.RightToLeft;
            }
        }

        /// <summary>
        /// Create the image from the system's icons
        /// </summary>
        /// <param name="icon">MessageBox Icon</param>
        private void CreateImage(MessageBoxImage icon)
        {
            switch (icon)
            {
                case MessageBoxImage.None:
                    ImagePlaceholder.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxImage.Information:
                    ImagePlaceholder.Source = SystemIcons.Information.ToImageSource();
                    break;
                case MessageBoxImage.Question:
                    ImagePlaceholder.Source = SystemIcons.Question.ToImageSource();
                    break;
                case MessageBoxImage.Warning:
                    ImagePlaceholder.Source = SystemIcons.Warning.ToImageSource();
                    break;
                case MessageBoxImage.Error:
                    ImagePlaceholder.Source = SystemIcons.Error.ToImageSource();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("icon");
            }
        }

        /// <summary>
        /// Show the startup animation
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Argument Parameter</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // This is set here to height after the width has been set 
            // so the details expander won't stretch the message box when it's opened
            SizeToContent = SizeToContent.Height;

            var animation = this.Resources["LoadAnimation"] as Storyboard;

            animation.Begin(this);
        }

        /// <summary>
        /// Show the closing animation
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Argument Parameter</param>
        private void MessageBoxWindow_Closing(object sender, CancelEventArgs e)
        {
            if (!this._animationRan)
            {
                // The animation won't run if the window is allowed to close, 
                // so here the animation starts, and the window's closing is canceled
                e.Cancel = true;

                var animation = TryFindResource("UnloadAnimation") as Storyboard;

                animation.Completed += this.AnimationCompleted;

                animation.Begin(this);
            }
        }

        /// <summary>
        /// Signals the closing animation ran, and close the window (for real this time)
        /// </summary>
        /// <param name="sender">Sender parameter</param>
        /// <param name="e">Argument Parameter</param>
        private void AnimationCompleted(object sender, EventArgs e)
        {
            this._animationRan = true;

            Close();
        }

        #endregion
    }
}
