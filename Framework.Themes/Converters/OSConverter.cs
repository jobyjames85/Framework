//-----------------------------------------------------------------------------
// <copyright file="OSConverter.cs" company="ActySystem">
//     Copyright (c) Acty System India Pvt. Ltd.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace Framework.Themes
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Data;

    /// <summary>
    /// Represent Converter
    /// </summary>
    public class OSConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Convert Method
        /// </summary>
        /// <param name="value">Value Parameter</param>
        /// <param name="targetType">Target Type</param>
        /// <param name="parameter">Parameter Object</param>
        /// <param name="culture">Culture Object</param>
        /// <returns>Return Value</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string detail = GetOSInfo();
            if (detail == "Windows8")
            {
                return 0;
            }

            return 6;
        }

        /// <summary>
        /// ConvertBack method
        /// </summary>
        /// <param name="value">Value Parameter</param>
        /// <param name="targetType">Target Type</param>
        /// <param name="parameter">Parameter Object</param>
        /// <param name="culture">Culture Object</param>
        /// <returns>Return Value</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region OS Information Members

        /// <summary>
        /// Get System Information
        /// </summary>
        /// <returns>Return Value</returns>
        private static string GetOSInfo()
        {
            ////Get Operating system information.
            OperatingSystem os = Environment.OSVersion;
            ////Get version information about the os.
            Version vs = os.Version;

            ////Variable to hold our return value
            string operatingSystem = null;

            if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        {
                            operatingSystem = "NT 3.51";
                            break;
                        }

                    case 4:
                        {
                            operatingSystem = "NT 4.0";
                            break;
                        }

                    case 5:
                        {
                            if (vs.Minor == 0)
                            {
                                operatingSystem = "2000";
                            }
                            else
                            {
                                operatingSystem = "XP";
                            }

                            break;
                        }

                    case 6:
                        {
                            if (vs.Minor == 0)
                            {
                                operatingSystem = "Vista";
                            }
                            else if (vs.Minor == 1)
                            {
                                operatingSystem = "7";
                            }
                            else
                            {
                                operatingSystem = "8";
                            }

                            break;
                        }

                    default:
                        break;
                }
            }

            ////Make sure we actually got something in our OS check
            ////We don't want to just return " Service Pack 2" or " 32-bit"
            ////That information is useless without the OS version.
            if (!string.IsNullOrEmpty(operatingSystem))
            {
                ////Got something.  Let's prepend "Windows" and get more info.
                operatingSystem = "Windows" + operatingSystem;
            }
            ////Return the information we've gathered.
            return operatingSystem;
        }

        #endregion
    }
}
