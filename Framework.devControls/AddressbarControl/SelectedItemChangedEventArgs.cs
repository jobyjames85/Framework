using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Framework.devControls
{
    public class SelectedItemChangedEventArgs : RoutedEventArgs
    {
        public SelectedItemChangedEventArgs(object Currentvalue)
        {
            this._CurrentValue = Currentvalue;
        }
        [CLSCompliantAttribute(false)]
        public object _CurrentValue;
    }
}
