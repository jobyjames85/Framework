using Framework.Data;
using Odyssey.Controls;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        internal int PID = 0;
        internal bool areaPageFlag = true;
        internal TreeView objTreeView;
        TreeViewItemEx subItemnew;
        internal OdcExpander group = null;
        internal bool isGroupAreaPage = true;

        public delegate void SelectedItemChangedEventHandler(Object sender, SelectedItemChangedEventArgs e);// declare a delegate 
        public event SelectedItemChangedEventHandler SelectedItemChanged; //delcares a event for the delegate 

        public string AreaPageType
        {
            get { return (string)GetValue(AreaPageTypeProperty); }
            set { SetValue(AreaPageTypeProperty, value); }
        }
        Dictionary<int, TreeViewItemEx> _dicTreeViewItemInAreaPage = new Dictionary<int, TreeViewItemEx>();
        // Using a DependencyProperty as the backing store for AreaPageType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AreaPageTypeProperty =
            DependencyProperty.Register("AreaPageType", typeof(string), typeof(HomePage), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty ItemsSourceProperty =
           DependencyProperty.Register("StructureItemsSource", typeof(List<SystemMenuTreeList>), typeof(HomePage), new PropertyMetadata(null));
        [CLSCompliantAttribute(false)]
        public List<SystemMenuTreeList> ItemsSource
        {
            get { return (List<SystemMenuTreeList>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MenuPath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MenuPathProperty =
            DependencyProperty.Register("MenuPath", typeof(string), typeof(HomePage), new UIPropertyMetadata(string.Empty, ChangeMenuPath));

        private static void ChangeMenuPath(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            String s = e.NewValue.ToString();
            HomePage objpage = d as HomePage;
            if (objpage != null)
            {
                objpage.GenerateAreaPage(e, s);
            }
        }

        public string MenuPath
        {
            get { return (string)GetValue(MenuPathProperty); }
            set { SetValue(MenuPathProperty, value); }
        }

        internal static Style objtemplate = null;
        public HomePage()
        {
            InitializeComponent();
            objtemplate = (Style)this.Resources["homeTreeitem"];
        }

        private void GenerateAreaPage(DependencyPropertyChangedEventArgs e, string path)
        {
            if (ItemsSource != null)
            {
                if (_dicTreeViewItemInAreaPage.Any())
                {
                    _dicTreeViewItemInAreaPage.Clear();
                }
                var ParentItemsList = ItemsSource.Where(p => p.PId == PID).OrderBy(p => p.DisplayIndex);
                if (path == "Home" || path == "ホーム" || path == "บ้าน" || path == "家")
                {
                    GenerateAreaPageGroups(ParentItemsList, string.Empty);
                }
                //else
                //{
                //    if (isGroupAreaPage)
                //    {
                //        GenerateAreaPageGroups(ItemsSource.Where(p => p.PId == PID).OrderBy(p => p.DisplayIndex), string.Empty);
                //    }
                //    else
                //    {
                //        GenerateAreaPageGroups(ItemsSource.Where(p => p.PId == PID).OrderBy(p => p.DisplayIndex), path);
                //    }
                //}
            }
        }

        private void GenerateAreaPageGroups(IEnumerable<SystemMenuTreeList> table, string GroupName)
        {
            LocalizeItemSelector localizeItemSelector;
            foreach (var item in table)
            {
                localizeItemSelector = new LocalizeItemSelector();
                CommonMethods.AddLocalizeItem(localizeItemSelector, "ja", item.NameJa != null ? item.NameJa : "PropertyValueNotSet");
                CommonMethods.AddLocalizeItem(localizeItemSelector, "en", item.NameEn != null ? item.NameEn : "PropertyValueNotSet");
                CommonMethods.AddLocalizeItem(localizeItemSelector, "th", item.NameTh != null ? item.NameTh : "PropertyValueNotSet");
                CommonMethods.AddLocalizeItem(localizeItemSelector, "zn", item.NameTh != null ? item.NameTh : "PropertyValueNotSet");
                if (item.PId == PID)
                {
                    if (string.IsNullOrEmpty(GroupName))
                    {
                        SetAreaPageLayoutGroup(localizeItemSelector);
                        if (areaPageFlag)
                            this.layoutGroup1.Items.Add(group);
                        else
                            this.layoutGroup2.Items.Add(group);
                        areaPageFlag = !areaPageFlag;
                        var prnts = ItemsSource.OrderBy(a => a.DisplayIndex).Where(p => p.PId == item.Id);
                        if (prnts.Any())
                            GenerateAreaPageGroups(prnts, GroupName);
                    }
                    else if (item.NameEn == GroupName || item.NameTh == GroupName || item.NameJa == GroupName) //// || item.SystemMenuItemRef.NameCh == GroupName)
                    {
                        SetAreaPageLayoutGroup(localizeItemSelector);

                        this.layoutGroup1.Items.Add(group);

                        var prnts = ItemsSource.OrderBy(a => a.DisplayIndex).Where(p => p.PId == item.Id);
                        if (prnts.Any())
                            GenerateAreaPageGroups(prnts, GroupName);
                    }
                }
                else
                {
                    SetAreaPageSubItems(GroupName, localizeItemSelector, item);
                }
            }
        }

        private void SetAreaPageLayoutGroup(LocalizeItemSelector localizeItemSelector)
        {
            group = new OdcExpander { IsExpanded = true };
            group.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            group.Header = localizeItemSelector.setLocalizeValue(group, OdcExpander.HeaderProperty);
            objTreeView = new TreeView();
            
            //objTreeView.PreviewMouseWheel += objTreeView_PreviewMouseWheel;
            KeyboardNavigation.SetTabNavigation(objTreeView, KeyboardNavigationMode.Continue);
            objTreeView.IsTabStop = false;
            KeyboardNavigation.SetTabNavigation(this, KeyboardNavigationMode.Cycle);
            group.Content=objTreeView;
        }

        /// <summary>
        /// Create TreeMenu and TreeMenuItem
        /// </summary>
        /// <param name="GroupName"></param>
        /// <param name="localizeItemSelector"></param>
        /// <param name="item"></param>
        private void SetAreaPageSubItems(string GroupName, LocalizeItemSelector localizeItemSelector, SystemMenuTreeList item)
        {
            Binding binding = new Binding();
            binding.Mode = BindingMode.TwoWay;
            binding.Source = this;
            binding.Path = new PropertyPath(Window.LanguageProperty);
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            subItemnew = new TreeViewItemEx();
            subItemnew.SetBinding(TreeViewItemEx.LanguageProperty, binding);
            KeyboardNavigation.SetTabNavigation(subItemnew, KeyboardNavigationMode.Continue);
            subItemnew.IsTabStop = true;
            subItemnew.IsExpanded = true;
            subItemnew.HorizontalAlignment = HorizontalAlignment.Left;
            subItemnew.Foreground = Brushes.Black;
            subItemnew.Header = localizeItemSelector.setLocalizeValue(subItemnew, TreeViewItemEx.HeaderProperty);
            _dicTreeViewItemInAreaPage.Add(item.Id, subItemnew);
            subItemnew.IsExpanded = true;
            if (_dicTreeViewItemInAreaPage.ContainsKey(item.PId))
                _dicTreeViewItemInAreaPage[item.PId].Items.Add(subItemnew);
            else
                objTreeView.Items.Add(subItemnew);
            var Col = ItemsSource.OrderBy(a => a.DisplayIndex).Where(p => p.PId == item.Id);
            if (0 < Col.Count())
                GenerateAreaPageGroups(Col, GroupName);
            else
            {
                //subItemnew.PageUri = item.PageUri;
                if (!string.IsNullOrEmpty(item.NameClass))
                {
                   // subItemnew.MouseLeftButtonUp += new MouseButtonEventHandler(newItem_MouseLeftButtonUp);
                    //subItemnew.PreviewKeyDown += new KeyEventHandler(subItemnew_PreviewKeyDown);
                }
            }
        }

    }
}
