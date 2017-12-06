using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace AppView.Converters
{
    /// <summary>
    /// Represents the progressConvert
    /// </summary>
    public class ToggleForTextConverter : IMultiValueConverter
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
            Typeface typeface = new Typeface((values[0] as System.Windows.Controls.Control).FontFamily, (values[0] as System.Windows.Controls.Control).FontStyle, (values[0] as System.Windows.Controls.Control).FontWeight, (values[0] as System.Windows.Controls.Control).FontStretch);
            FormattedText ft = new FormattedText((values[0] as System.Windows.Controls.TextBox).Text, System.Globalization.CultureInfo.CurrentCulture, System.Windows.FlowDirection.LeftToRight, typeface, (values[0] as System.Windows.Controls.Control).FontSize, Brushes.Black);
            if (ft.Width > (values[0] as System.Windows.Controls.TextBox).Width)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
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
            throw new NotImplementedException();
        }
    }
}
