using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AppView.Converters
{
    /// <summary>
    /// Represents the ListToStringConverter
    /// </summary>
    [ValueConversion(typeof(List<string>), typeof(string))]
    public class ListToStringConverter : IValueConverter
    {
        /// <summary>
        /// Convert Value
        /// </summary>
        /// <param name="value">Pass value</param>
        /// <param name="targetType">Target Type</param>
        /// <param name="parameter">Send Parameter</param>
        /// <param name="culture">Current culture</param>
        /// <returns>Return Value</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(string))
            {
                throw new InvalidOperationException("The target must be a String");
            }

            return string.Join(", ", ((List<string>)value).ToArray());
        }

        /// <summary>
        /// ConvertBack value
        /// </summary>
        /// <param name="value">Pass value</param>
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
