using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    /// <summary>
    /// Represent the OSVersion
    /// </summary>
    public static class OSVersion
    {
        #region private Field
        /// <summary>
        /// Field for OSANYSERVER
        /// </summary>
        private const int OSANYSERVER = 29;
        #endregion

        #region Public Static method
        /// <summary>
        /// Get OS Version
        /// </summary>
        /// <returns>Return Version</returns>
        public static bool GetOSVersion()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32S:
                    ////return "Win 3.1";
                    return false;
                case PlatformID.Win32Windows:
                    switch (Environment.OSVersion.Version.Minor)
                    {
                        case 0:
                            ////PopupMessageBox.Show("win95", System.Windows.MessageBoxButton.OK);
                            return false;
                        ////return "Win95";
                        case 10:
                            ////PopupMessageBox.Show("Win98", System.Windows.MessageBoxButton.OK);
                            return false;
                        ////return "Win98";
                        case 90:
                            ////PopupMessageBox.Show("Win98", System.Windows.MessageBoxButton.OK);
                            return false;
                        ////return "Win98";
                    }

                    break;

                case PlatformID.Win32NT:
                    switch (Environment.OSVersion.Version.Major)
                    {
                        case 3:
                            ////PopupMessageBox.Show("NT 3.51", System.Windows.MessageBoxButton.OK);
                            return false;
                        ////return "NT 3.51";
                        case 4:
                            ////PopupMessageBox.Show("NT 4.0", System.Windows.MessageBoxButton.OK);
                            return false;
                        ////return "NT 4.0";
                        case 5:
                            switch (Environment.OSVersion.Version.Minor)
                            {
                                case 0:
                                    ////PopupMessageBox.Show("Win2000", System.Windows.MessageBoxButton.OK);
                                    return false;
                                ////return "Win2000";
                                case 1:
                                    ////PopupMessageBox.Show("WinXP", System.Windows.MessageBoxButton.OK);
                                    return false;
                                ////return "WinXP";
                                case 2:
                                    ////PopupMessageBox.Show("Win2003", System.Windows.MessageBoxButton.OK);
                                    return false;
                                ////return "Win2003";
                            }

                            break;

                        case 6:
                            switch (Environment.OSVersion.Version.Minor)
                            {
                                case 0:
                                    ////PopupMessageBox.Show("Vista/Win2008Server", System.Windows.MessageBoxButton.OK);
                                    return false;
                                ////return "Vista/Win2008Server";
                                case 1:
                                    ////PopupMessageBox.Show("Win7/Win2008Server R2", System.Windows.MessageBoxButton.OK);
                                    return false;
                                ////return "Win7/Win2008Server R2";
                                case 2:
                                    if (IsWindowsServer())
                                    {
                                        ////PopupMessageBox.Show("Win2012Server", System.Windows.MessageBoxButton.OK);
                                        return false;
                                    }
                                    else
                                    {
                                        ////PopupMessageBox.Show("Win8", System.Windows.MessageBoxButton.OK);
                                        return true;
                                    }
                                ////return "Win8/Win2012Server";
                                case 3:
                                    if (IsWindowsServer())
                                    {
                                        ////PopupMessageBox.Show("Win2012Server R2", System.Windows.MessageBoxButton.OK);
                                        return false;
                                    }
                                    else
                                    {
                                        ////PopupMessageBox.Show("Win8.1", System.Windows.MessageBoxButton.OK);
                                        return true;
                                    }
                                ////return "Win8.1/Win2012Server R2";
                            }

                            break;
                    }

                    break;

                case PlatformID.WinCE:
                    ////PopupMessageBox.Show("Win CE", System.Windows.MessageBoxButton.OK);
                    return false;
                ////return "Win CE";
            }

            ////PopupMessageBox.Show("Unknown", System.Windows.MessageBoxButton.OK);
            return false;
            ////return "Unknown";
        }

        /// <summary>
        /// Check WindowsServer
        /// </summary>
        /// <returns>Return Value</returns>
        public static bool IsWindowsServer()
        {
            return OSVersion.IsOS(OSVersion.OSANYSERVER);
        }
        #endregion

        #region Private Static Method
        /// <summary>
        /// OS Server
        /// </summary>
        /// <param name="os">OS Parameter</param>
        /// <returns>Return Value</returns>
        [DllImport("shlwapi.dll", SetLastError = true, EntryPoint = "#437")]
        private static extern bool IsOS(int os);
        #endregion
    }
}
