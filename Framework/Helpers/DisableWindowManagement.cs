using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    /// <summary>
    /// Helper class for disable TaskBar
    /// </summary>
    public class DisableWindowManagement
    {
        /// <summary>
        /// Hide Window
        /// </summary>
        private const int SWHIDE = 0;

        /// <summary>
        /// Show Window
        /// </summary>
        private const int SWSHOW = 1;

        /// <summary>
        /// TaskBar Button
        /// </summary>
        private IntPtr hwndTaskBar;

        /// <summary>
        /// TaskBar Button
        /// </summary>
        private IntPtr hwndTaskBarButton;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisableWindowManagement"/> class.
        /// This constructor gets the window handles for the Taskbar and the
        /// Start menu globe.
        /// </summary>
        public DisableWindowManagement()
        {
            this.hwndTaskBar = FindWindow("Shell_TrayWnd", string.Empty);
            this.hwndTaskBarButton = FindWindowEx(IntPtr.Zero, IntPtr.Zero, (IntPtr)0xC017, null);
        }

        /// <summary>
        /// This method hides both the Taskbar and the Globe.
        /// </summary>
        public void DisableTaskBar()
        {
            ShowWindow(this.hwndTaskBar, SWHIDE);
            ShowWindow(this.hwndTaskBarButton, SWHIDE);
        }

        /// <summary>
        /// This method shows both the Taskbar and the Globe.
        /// </summary>
        public void EnableTaskBar()
        {
            ShowWindow(this.hwndTaskBar, SWSHOW);
            ShowWindow(this.hwndTaskBarButton, SWSHOW);
        }

        /// <summary>
        /// FindWindow Method
        /// </summary>
        /// <param name="className">Class Name</param>
        /// <param name="windowText">Window Text</param>
        /// <returns>Return Value</returns>
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string className, string windowText);

        /// <summary>
        /// This slightly non-standard version of FindWindowEx is the key to
        /// making this solution work.
        /// </summary>
        /// <param name="parentHwnd">Parent window</param>
        /// <param name="childAfterHwnd">ChildAfter Window</param>
        /// <param name="className">use an instead of a string for the className, this causes the ATOM code to be invoked.</param>
        /// <param name="windowText">Window Class</param>
        /// <returns>Return Value</returns>
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindowEx(IntPtr parentHwnd, IntPtr childAfterHwnd, IntPtr className, string windowText);

        /// <summary>
        /// ShowWindow Method
        /// </summary>
        /// <param name="hwnd">Parent Window</param>
        /// <param name="command">Command Class</param>
        /// <returns>Return Value</returns>
        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hwnd, int command);
    }
}
