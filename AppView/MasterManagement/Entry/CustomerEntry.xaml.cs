using AppViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppView
{
    /// <summary>
    /// Interaction logic for CustomerEntry.xaml
    /// </summary>
    public partial class CustomerEntry : Page
    {
        public ICollectionView GroupedCustomers { get; private set; }

        public CustomerEntry()
        {
            InitializeComponent();
            this.DataContext = new CustomerEntryViewModel();
            //GroupedCustomers = new ListCollectionView(obj.SystemMenuTree1.ToList());
            //GroupedCustomers.GroupDescriptions.Add(new PropertyGroupDescription("PId"));
            //gridTest.ItemsSource = GroupedCustomers;
            //gridTest.ItemsSource = obj.SystemMenuTree1.ToList();
        }
        private void DetailView_Click(object sender, RoutedEventArgs e)
        {
            gridTest.AreRowDetailsFrozen = true;
            gridTest.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.Collapsed;
        }
    }
}
