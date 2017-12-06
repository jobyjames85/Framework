using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace Framework
{
    /// <summary>
    ///  Represent the Application IdleTime
    /// </summary>
    public class ApplicationIdleTime
    {
        #region Private Field

        /// <summary>
        /// Field Timer
        /// </summary>
        private Timer timer;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationIdleTime"/> class. 
        /// </summary>
        public ApplicationIdleTime()
        {
            this.TickTimeCount = 60000;
            this.timer = new Timer();
            this.timer.Interval = 10;
            this.timer.Elapsed += this.Timer_Tick;
            this.timer.Start();
        }

        #endregion

        #region Public Property

        /// <summary>
        /// Gets or sets the window
        /// </summary>
        public Window CurrentWindow { get; set; }

        /// <summary>
        /// Gets or sets the TickTimeCount
        /// </summary>
        public uint TickTimeCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsTimerStart 
        /// </summary>
        public bool IsTimerStart { get; set; }

        #endregion

        #region Public Static Method

        /// <summary>
        /// GetIdle Time
        /// </summary>
        /// <returns>Return Value</returns>
        public static uint GetIdleTime()
        {
            LASTINPUTINFO lastUserAction = new LASTINPUTINFO();
            lastUserAction.CbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastUserAction);
            GetLastInputInfo(ref lastUserAction);
            return (uint)Environment.TickCount - lastUserAction.DwTime;
        }

        /// <summary>
        /// GetTick Count
        /// </summary>
        /// <returns>Return Value</returns>
        public static long GetTickCount()
        {
            return Environment.TickCount;
        }

        /// <summary>
        /// GetLast InputTime
        /// </summary>
        /// <returns>Return Value</returns>
        public static long GetLastInputTime()
        {
            LASTINPUTINFO lastUserAction = new LASTINPUTINFO();
            lastUserAction.CbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastUserAction);
            if (!GetLastInputInfo(ref lastUserAction))
            {
                throw new Exception(GetLastError().ToString());
            }

            return lastUserAction.DwTime;
        }

        #endregion

        #region Public Method

        /// <summary>
        /// LockWork Station
        /// </summary>
        /// <returns>Return Value</returns>
        [DllImport("User32.dll")]
        public static extern bool LockWorkStation();

        #endregion

        #region Private Method

        /// <summary>
        /// GetLast InputInfo
        /// </summary>
        /// <param name="dummy">Parameter Object</param>
        /// <returns>Return Value</returns>
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO dummy);

        /// <summary>
        /// GetLast Error
        /// </summary>
        /// <returns>Return Value</returns>
        [DllImport("Kernel32.dll")]
        private static extern uint GetLastError();

        /// <summary>
        /// timer Tick Method
        /// </summary>
        /// <param name="sender">Object Parameter</param>
        /// <param name="e">Argument parameter</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.IsTimerStart)
            {
                if (GetIdleTime() > this.TickTimeCount)
                {
                    ////LockWorkStation();
                    if (this.CurrentWindow != null)
                    {
                        Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            CurrentWindow.Close();
                        }));
                    }
                }
            }
        }
        #endregion
    }
}
