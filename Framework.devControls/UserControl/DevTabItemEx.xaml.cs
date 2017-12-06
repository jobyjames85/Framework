using Framework.Data;
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

namespace Framework.devControls
{
    /// <summary>
    /// Interaction logic for DevTabItemEx.xaml
    /// </summary>
    public partial class DevTabItemEx : FabTab.FabTabItem
    {
        static string commonAreaPagePath = "pack://application:,,,/Framework.devControls;component/UserControl/HomePage.xaml";
        private const string HomeTitle = "Home";
        public string CommonAreaPage { get; set; }

        [CLSCompliantAttribute(false)]
        public List<SystemMenuTreeList> BreadCrumbBarItemsSource
        {
            get { return (List<SystemMenuTreeList>)GetValue(BreadCrumbBarItemsSourceProperty); }
            set { SetValue(BreadCrumbBarItemsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BreadCrumbBarItemsSourceProperty =
            DependencyProperty.Register("BreadCrumbBarItemsSource", typeof(List<SystemMenuTreeList>), typeof(DevTabItemEx), new UIPropertyMetadata(null, BreadCrumbBarItemsSourceChanged));

        [CLSCompliantAttribute(false)]
        public List<SystemMenuTreeList> CommonAreaPageItemsSource
        {
            get { return (List<SystemMenuTreeList>)GetValue(CommonAreaPageItemsSourceProperty); }
            set { SetValue(CommonAreaPageItemsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommonAreaPageItemsSourceProperty =
            DependencyProperty.Register("CommonAreaPageItemsSource", typeof(List<SystemMenuTreeList>), typeof(DevTabItemEx), new UIPropertyMetadata(null));

        public DevTabItemEx()
        {
            InitializeComponent();
            
        }

        private void BreadcrumbBar_SelectedBreadCrumbItemChanged_1(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private static void BreadCrumbBarItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // var Collection=((ActySystem.Telas.Wpf.Controls.DocumnetPanelEx1)(d)).BreadCrumbBarItemsSource;
            DevTabItemEx documentpanel = d as DevTabItemEx;
            List<SystemMenuTreeList> itemsSource = e.NewValue as List<SystemMenuTreeList>;
            if (documentpanel != null && itemsSource != null)
            {
                documentpanel.childBreadItem.generateBread(itemsSource);
                documentpanel.CommonAreaPage = HomeTitle;
                documentpanel.CommonAreaPageItemsSource = itemsSource;
                documentpanel.mainFrame.Navigate(new Uri(commonAreaPagePath), HomeTitle);
            }
        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            (e.Content as Page).Focus();
            FrameEx frame = sender as FrameEx;
            if (frame.Content is HomePage)
            {
                CreateCommonAreaPage(frame.Content as HomePage, e.ExtraData);
            }
            Page page = frame.Content as Page;
            page.Background = Brushes.Transparent;
        }

        private void CreateCommonAreaPage(HomePage AreaPage, object ExtraData)
        {
            Binding binding = new Binding();
            binding.Mode = BindingMode.TwoWay;
            binding.Source = this;
            binding.Path = new PropertyPath(DevTabItemEx.LanguageProperty);
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            AreaPage.SetBinding(Page.LanguageProperty, binding);
            AreaPage.AreaPageType = ExtraData != null ? ExtraData.ToString() : string.Empty;
            AreaPage.ItemsSource = CommonAreaPageItemsSource;
            //AreaPage.isGroupAreaPage = IsAreaPageForGroup;
            AreaPage.PID = 0;
            //AreaPage.MenuPath = ExtraData!=null?ExtraData.ToString():string.Empty;
            AreaPage.MenuPath = CommonAreaPage != null ? CommonAreaPage.ToString() : string.Empty;
            AreaPage.SelectedItemChanged += AreaPage_SelectedItemChanged;
        }

        public void NavigateToPage(string PageUri)
        {
            Application.Current.MainWindow.Cursor = Cursors.Wait;
            mainFrame.RemoveFirstPageFromJournal(mainFrame, 5);
            mainFrame.Navigate(new Uri(PageUri), "");
            Application.Current.MainWindow.Cursor = Cursors.Arrow;
        }

        private void AreaPage_SelectedItemChanged(object sender, SelectedItemChangedEventArgs e)
        {
            
        }
    }
}
