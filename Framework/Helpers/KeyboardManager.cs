using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    /// <summary>
    /// Represent the Window 7 Touch Keyboard
    /// </summary>
    public static class KeyboardManager
    {
        /// <summary>
        /// Field for WM_SYSCOMMAND
        /// </summary>
        private const uint WMSYSCOMMAND = 0x112;

        /// <summary>
        /// Field for SC_RESTORE
        /// </summary>
        private const uint SCRESTORE = 0xf120;

        /// <summary>
        /// Field for OnScreenKeyboardExe
        /// </summary>
        private const string OnScreenKeyboardExe = "osk.exe";

        #region public methods

        /// <summary>
        /// Launch OnScreenKeyboard
        /// </summary>
        public static void LaunchOnScreenKeyboard()
        {
            ////var processes = Process.GetProcessesByName("osk").ToArray();
            ////if (processes.Any())
            ////{
            ////    return;
            ////}

            var keyboardManagerPath = "osk.exe";
            Process.Start(keyboardManagerPath);
        }

        /// <summary>
        /// Kill OnScreenKeyboard
        /// </summary>
        public static void KillOnScreenKeyboard()
        {
            var processes = Process.GetProcessesByName("osk").ToArray();
            foreach (var proc in processes)
            {
                proc.Kill();
            }
        }

        #endregion

        /// <summary>
        /// Start Keyboard
        /// </summary>
        public static void StartOsk()
        {
            IntPtr ptr = new IntPtr();
            bool sucessfullyDisabledWow64Redirect = false;

            //// Disable x64 directory virtualization if we're on x64,
            //// otherwise keyboard launch will fail.
            if (System.Environment.Is64BitOperatingSystem)
            {
                sucessfullyDisabledWow64Redirect =
                    Wow64DisableWow64FsRedirection(ref ptr);
            }

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = OnScreenKeyboardExe;
            //// We must use ShellExecute to start osk from the current thread
            //// with psi.UseShellExecute = false the CreateProcessWithLogon API 
            //// would be used which handles process creation on a separate thread 
            //// where the above call to Wow64DisableWow64FsRedirection would not 
            //// have any effect.
            ////
            psi.UseShellExecute = true;
            Process.Start(psi);

            //// Re-enable directory virtualisation if it was disabled.
            if (System.Environment.Is64BitOperatingSystem)
            {
                if (sucessfullyDisabledWow64Redirect)
                {
                    Wow64RevertWow64FsRedirection(ptr);
                }
            }
        }

        /// <summary>
        /// Redirection value
        /// </summary>
        /// <param name="ptr">Parameter Value</param>
        /// <returns>Return Value</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool Wow64RevertWow64FsRedirection(IntPtr ptr);

        /// <summary>
        /// SendMessage Method
        /// </summary>
        /// <param name="hWnd">sender Value</param>
        /// <param name="msg">Message Value</param>
        /// <param name="wParam">Parameter Value</param>
        /// <param name="lParam">Get Value</param>
        /// <returns>Return Value</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Redirection Value
        /// </summary>
        /// <param name="ptr">Parameter Value</param>
        /// <returns>Return Value</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);
    }
}
