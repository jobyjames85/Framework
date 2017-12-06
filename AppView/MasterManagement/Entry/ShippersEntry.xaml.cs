using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using AppViewModel;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppView
{
    /// <summary>
    /// Interaction logic for ShippersEntry.xaml
    /// </summary>
    public partial class ShippersEntry : Page
    {
        public ShippersEntry()
        {
            InitializeComponent();
            this.DataContext = new ShippersEntryViewModel();
        }
    }
}
