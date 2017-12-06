using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using AppViewModel;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppView
{
    /// <summary>
    /// Interaction logic for SuppliersEntry.xaml
    /// </summary>
    public partial class SuppliersEntry : Page
    {
        public SuppliersEntry()
        {
            InitializeComponent();
            this.DataContext = new SuppliersEntryViewModel();
        }

        private async void sild_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            sild.Value = 2;
            await Task.Delay(1000);
            sild.Value = 1;
        }

        private void sild_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if ((sender as System.Windows.Controls.Primitives.RangeBase).Value > 1.2)
            {
                sild.Value = 2;
            }
        }
    }
}
