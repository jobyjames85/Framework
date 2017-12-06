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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Framework.devControls.CustomControl
{
    /// <summary>
    /// Interaction logic for ProgressBar
    /// </summary>
    public partial class ProgressBar : UserControl
    {
        #region Private Field

        /// <summary>
        /// Field AnimationTimer
        /// </summary>
        private readonly DispatcherTimer animationTimer;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBar"/> class.
        /// </summary>
        public ProgressBar()
        {
            this.InitializeComponent();
            this.animationTimer = new DispatcherTimer(DispatcherPriority.ContextIdle, Dispatcher);
            this.animationTimer.Interval = new TimeSpan(0, 0, 0, 0, 90);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Animation Start Method
        /// </summary>
        private void Start()
        {
            this.animationTimer.Tick += this.HandleAnimationTick;
            this.animationTimer.Start();
        }

        /// <summary>
        /// Animation Stop
        /// </summary>
        private void Stop()
        {
            this.animationTimer.Stop();
            this.animationTimer.Tick -= this.HandleAnimationTick;
        }

        /// <summary>
        /// Tick Event
        /// </summary>
        /// <param name="sender">sender Parameter</param>
        /// <param name="e">Argument Parameter</param>
        private void HandleAnimationTick(object sender, EventArgs e)
        {
            SpinnerRotate.Angle = (SpinnerRotate.Angle + 36) % 360;
        }

        /// <summary>
        /// Load Event
        /// </summary>
        /// <param name="sender">sender Parameter</param>
        /// <param name="e">Argument Parameter</param>
        private void HandleLoaded(object sender, RoutedEventArgs e)
        {
            const double Step = Math.PI * 2 / 10.0;
            const double Offset = Math.PI;

            C0.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (0.0 * Step)) * 50.0));
            C0.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (0.0 * Step)) * 50.0));
            C1.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (1.0 * Step)) * 50.0));
            C1.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (1.0 * Step)) * 50.0));
            C2.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (2.0 * Step)) * 50.0));
            C2.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (2.0 * Step)) * 50.0));
            C3.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (3.0 * Step)) * 50.0));
            C3.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (3.0 * Step)) * 50.0));
            C4.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (4.0 * Step)) * 50.0));
            C4.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (4.0 * Step)) * 50.0));
            C5.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (5.0 * Step)) * 50.0));
            C5.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (5.0 * Step)) * 50.0));
            C6.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (6.0 * Step)) * 50.0));
            C6.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (6.0 * Step)) * 50.0));
            C7.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (7.0 * Step)) * 50.0));
            C7.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (7.0 * Step)) * 50.0));
            C8.SetValue(Canvas.LeftProperty, 50.0 + (Math.Sin(Offset + (8.0 * Step)) * 50.0));
            C8.SetValue(Canvas.TopProperty, 50 + (Math.Cos(Offset + (8.0 * Step)) * 50.0));
        }

        /// <summary>
        /// unloaded Event
        /// </summary>
        /// <param name="sender">sender Parameter</param>
        /// <param name="e">Argument Parameter</param>
        private void HandleUnloaded(object sender, RoutedEventArgs e)
        {
            this.Stop();
        }

        /// <summary>
        /// VisibleChanged Event
        /// </summary>
        /// <param name="sender">sender Parameter</param>
        /// <param name="e">Argument Parameter</param>
        private void HandleVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            bool isVisible = (bool)e.NewValue;

            if (isVisible)
            {
                this.Start();
            }
            else
            {
                this.Stop();
            }
        }
        #endregion
    }
}

