using AppView.Interface;
using AppViewModel;
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
using System.Windows.Shapes;

namespace AppView
{
    /// <summary>
    /// Interaction logic for CategorieEntry.xaml
    /// </summary>
    public partial class CategorieEntry : Page, ILanguageChange
    {
        public CategorieEntry()
        {
            InitializeComponent();
            this.DataContext = new CategoriesViewModel();
            
        }

        public void LanguageChanged(string currentCulture)
        {
            ////Properties.Resources.Culture = CultureInfo.GetCultureInfo(currentCulture);
            CheckButton.GetBindingExpression(Button.ContentProperty).UpdateTarget();
            //scanParcelButton.GetBindingExpression(Button.ContentProperty).UpdateTarget();
            //uncollectedParcelButton.GetBindingExpression(Button.ContentProperty).UpdateTarget();
            //lockerSummaryButton.GetBindingExpression(Button.ContentProperty).UpdateTarget();
        }
    }
}
