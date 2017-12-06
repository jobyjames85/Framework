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
    /// Interaction logic for ProductsEntry.xaml
    /// </summary>
    public partial class ProductsEntry : Page
    {
        public ProductsEntry()
        {
            InitializeComponent();
            this.DataContext = new ProductsEntryViewModel();
        }
    }
}
