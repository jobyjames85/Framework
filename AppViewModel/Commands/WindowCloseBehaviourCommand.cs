using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace AppViewModel.Commands
{
    /// <summary>
    /// Represents the WindowClose
    /// </summary>
    public class WindowCloseBehaviourCommand : Behavior<Window>
    {
        #region Field property
        //<i:Interaction.Behaviors>
        //<vm:WindowCloseBehaviourCommand CloseButton="{Binding ElementName=FinishButton}"/>
        //</i:Interaction.Behaviors>
        //<Button x:Name="FinishButton" Content="{x:Static prop:Resources.DriverFinish}" FontSize="25" Foreground="White" Height="55" Margin="0,0,30,-30" HorizontalAlignment="Right" VerticalAlignment="Bottom" Width="175"/>
        /// <summary>
        /// Field for Command
        /// </summary>
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(WindowCloseBehaviourCommand));

        /// <summary>
        /// Field for CommandParameter
        /// </summary>
        public static readonly DependencyProperty CommandParameterProperty = DependencyProperty.Register("CommandParameter", typeof(object), typeof(WindowCloseBehaviourCommand));

        /// <summary>
        /// Field for CloseButton
        /// </summary>
        public static readonly DependencyProperty CloseButtonProperty = DependencyProperty.Register("CloseButton", typeof(Button), typeof(WindowCloseBehaviourCommand), new FrameworkPropertyMetadata(null, OnButtonChanged));

        #endregion

        #region public property

        /// <summary>
        /// Gets or sets the Command
        /// </summary>
        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }

            set
            {
                this.SetValue(CommandProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the CommandParameter
        /// </summary>
        public object CommandParameter
        {
            get
            {
                return this.GetValue(CommandParameterProperty);
            }

            set
            {
                this.SetValue(CommandParameterProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the CloseButton
        /// </summary>
        public Button CloseButton
        {
            get
            {
                return (Button)GetValue(CloseButtonProperty);
            }

            set
            {
                this.SetValue(CloseButtonProperty, value);
            }
        }

        #endregion

        #region private Method

        /// <summary>
        /// OnButtonChanged Method
        /// </summary>
        /// <param name="d">Parameter Object</param>
        /// <param name="e">Event Parameter</param>
        private static void OnButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = (Window)((WindowCloseBehaviourCommand)d).AssociatedObject;
            ((Button)e.NewValue).Click += (s, e1) =>
            {
                var command = ((WindowCloseBehaviourCommand)d).Command;
                var commandParameter = ((WindowCloseBehaviourCommand)d).CommandParameter;
                if (command != null)
                {
                    command.Execute(commandParameter);
                }

                if (commandParameter != null)
                {
                   
                }

                window.Close();
            };
        }

        #endregion
    }
}
