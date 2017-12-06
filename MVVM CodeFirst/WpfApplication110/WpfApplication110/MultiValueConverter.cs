using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApplication110
{
    public class MultiValueConverter : IMultiValueConverter
    {
        /// <summary>
        /// Convert Method
        /// </summary>
        /// <param name="values">Collection Object</param>
        /// <param name="targetType">Target Type</param>
        /// <param name="parameter">Send Parameter</param>
        /// <param name="culture">Current Culture</param>
        /// <returns>Return Array</returns>
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return values.ToArray();
        }

        /// <summary>
        /// ConvertBack Method
        /// </summary>
        /// <param name="value">Pass Object</param>
        /// <param name="targetTypes">Target Type</param>
        /// <param name="parameter">Send Parameter</param>
        /// <param name="culture">Current Culture</param>
        /// <returns>Return Array</returns>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException("No two way conversion, one way binding only.");
        }
    }
}
