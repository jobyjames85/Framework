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
    /// Interaction logic for TerritoriesEntry.xaml
    /// </summary>
    public partial class TerritoriesEntry : Page
    {
        public TerritoriesEntry()
        {
            InitializeComponent();
            this.DataContext = new TerritoriesEntryViewModel();
        }
    }
}
