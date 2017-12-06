using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AppView.Converters
{
    /// <summary>
    /// Represents the progressConvert
    /// </summary>
    public class ProgressConvert : IValueConverter
    {
        /// <summary>
        /// Convert Value
        /// </summary>
        /// <param name="value">Progress value</param>
        /// <param name="targetType">Target Type</param>
        /// <param name="parameter">Send Parameter</param>
        /// <param name="culture">Current culture</param>
        /// <returns>Return Visibility</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }

        /// <summary>
        /// ConvertBack value
        /// </summary>
        /// <param name="value">Progress value</param>
        /// <param name="targetType">Target Type</param>
        /// <param name="parameter">Send Parameter</param>
        /// <param name="culture">Current culture</param>
        /// <returns>Return Visibility</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
