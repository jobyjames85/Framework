using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Framework
{
    /// <summary>
    /// Represent the ApplicationTheme
    /// </summary>
    public static class ApplicationTheme
    {
        #region  Public Static Method

        /// <summary>
        /// SetTheme Method
        /// </summary>
        public static void SetTheme()
        {
            Task.Run(() => Theme());
        }

        /// <summary>
        /// Current Theme
        /// </summary>
        private static void Theme()
        {
            try
            {
                //APIService apiService = new APIService();
                //Theme theme = apiService.GetTheme();
                //((App)Application.Current).ThemeChange(theme.ToString());
            }
            catch (Exception)
            {
            }
        }

        #endregion
    }
}
