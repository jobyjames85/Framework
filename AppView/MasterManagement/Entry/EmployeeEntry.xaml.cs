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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using AppViewModel;
using System.Windows.Shapes;
using WpfPageTransitions;

namespace AppView
{
    /// <summary>
    /// Interaction logic for EmployeeEntry.xaml
    /// </summary>
    public partial class EmployeeEntry : Page
    {
        public EmployeeEntry()
        {
            InitializeComponent();

            this.DataContext = new EmployeeEntryViewModel();
            cmbTransitionTypes.ItemsSource = Enum.GetNames(typeof(PageTransitionType));
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            UserControl newPage = new UserControl();
            newPage.Content = new Button() { Content = "hello" };
            pageTransitionControl.ShowPage(newPage);
        }

        private void cmbTransitionTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), cmbTransitionTypes.SelectedItem.ToString(), true);
        }

        private void btnNextPage1_Click(object sender, RoutedEventArgs e)
        {
            UserControl usercontrol = new UserControl();
            usercontrol.Content = new Button() { Content = "Test Page" };
            pageTransitionControl.ShowPage(usercontrol);
        }		
    }
}
