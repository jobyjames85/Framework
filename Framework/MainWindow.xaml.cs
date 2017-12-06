//-----------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="ActySystem">
//     Copyright (c) Acty System India Pvt. Ltd.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace Framework
{
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
    using Framework.Themes;
    using Data;
    using Odyssey;
    using Odyssey.Controls;
    using Framework.devControls;
    using System.IO;
    using AppModel.Model;
    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Dictionary<int, TreeViewItemEx> _dicflattenedTree = new Dictionary<int, TreeViewItemEx>();
        internal TreeViewItemEx SubItem = null;
        internal TreeView objtree = null;
        internal OutlookSection NavGroup = null;

        /// <summary>
        /// Gets Sets ThemesTitleIcon
        /// </summary>
        public ImageSource ThemesTitleIcon
        {
            get { return (ImageSource)GetValue(ThemesTitleIconProperty); }
            set { SetValue(ThemesTitleIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ThemesTitleIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThemesTitleIconProperty =
            DependencyProperty.Register("ThemesTitleIcon", typeof(ImageSource), typeof(MainWindow), new UIPropertyMetadata(null));

        public static readonly DependencyProperty StructureItemsSourceProperty =
           DependencyProperty.Register("StructureItemsSource", typeof(List<SystemMenuTreeList>), typeof(MainWindow), new PropertyMetadata(null));
        
        public List<SystemMenuTreeList> StructureItemsSource
        {
            get { return (List<SystemMenuTreeList>)GetValue(StructureItemsSourceProperty); }
            set { SetValue(StructureItemsSourceProperty, value); }

        }

        internal static Style objtemplate = null;

        public bool IsWindows8 { get; set; }
        #region private Field 

        /// <summary>
        /// Field for Current Main Window Application
        /// </summary>
        private App app = App.Current as App;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            objtemplate = (Style)this.Resources["treeviewStyle"];
            Style objWindow = new System.Windows.Style();
            ResourceDictionary _objStructure = new ResourceDictionary();
            _objStructure.Source = new Uri("pack://application:,,,/Framework.Themes;;component/SkinsShapes/ClassicSkin.xaml", UriKind.Absolute);
            app.changeSkin("Metro");
            objWindow = (Style)_objStructure["CustSkin"];
            //this.Style = null;CustSkinTemp
            this.Style = objWindow;
            ThemesTitleIcon = new BitmapImage(new Uri("pack://application:,,,/Framework;;component/Images/NewNorthwindImage.png"));
            this.IsWindows8 = OSVersion.GetOSVersion();
            if (this.IsWindows8 == true)
            {
                InkInputHelper.DisableWPFTabletSupport();
            }
            Entities1 objData = new Entities1();
            var ddd = objData.SystemMenuItems.ToList();
            List<SystemMenuTreeList> objdata = new List<SystemMenuTreeList>();
            foreach (var item in ddd)
            {
                objdata.Add(new SystemMenuTreeList() { Id = item.Id, NameCh = item.NameCh, NameClass = item.NameClass, NameEn = item.NameEn, NameJa = item.NameJa, NameTh = item.NameTh, PId = objData.SystemMenuTrees.Where(p => p.Id == item.Id).Select(p => p.PId).FirstOrDefault(), PageUri = item.PageUri, DisplayIndex = objData.SystemMenuTrees.Where(p => p.Id == item.Id).Select(p => p.DisplayIndex).FirstOrDefault() });
            }
            Tab1.BreadCrumbBarItemsSource = objdata;
            StructureItemsSource = objdata;
            GenerateNavBarControl();

            OutlookSection objOutlookSection = new OutlookSection();
            objOutlookSection.Header = "Master Details";
            objOutlookSection.Width = 220;
            NavigationBar.Sections.Add(objOutlookSection);
        }

        private void GenerateNavBarControl()
        {
            if (StructureItemsSource != null)
            {
                if (_dicflattenedTree.Any())
                {
                    _dicflattenedTree.Clear();
                }
                var objItemWithZeroPId = StructureItemsSource.Where(p => p.PId == 0).OrderBy(p => p.DisplayIndex);
                if (objItemWithZeroPId.Any())
                {
                    GenerateNavControlTreeStructure(objItemWithZeroPId);
                }
            }
            NavigationBar.SelectedSectionIndex=1;
        }

        public void GenerateNavControlTreeStructure(IEnumerable<SystemMenuTreeList> table)
        {
            LocalizeItemSelector localizeItemSelector;
            foreach (var item in table)
            {
                localizeItemSelector = new LocalizeItemSelector();
                CommonMethods.AddLocalizeItem(localizeItemSelector, "ja", item.NameJa != null ? item.NameJa : "PropertyValueNotSet");
                CommonMethods.AddLocalizeItem(localizeItemSelector, "en", item.NameEn != null ? item.NameEn : "PropertyValueNotSet");
                CommonMethods.AddLocalizeItem(localizeItemSelector, "th", item.NameTh != null ? item.NameTh : "PropertyValueNotSet");
                CommonMethods.AddLocalizeItem(localizeItemSelector, "zn", item.NameCh != null ? item.NameCh : "PropertyValueNotSet");

                if (item.PId == 0)
                {
                    SetNavBarGroup(localizeItemSelector, item);
                    var parentid = StructureItemsSource.OrderBy(a => a.DisplayIndex).Where(p => p.PId == item.Id);
                    GenerateNavControlTreeStructure(parentid);
                }
                else
                {
                    SetNavGroupSubItem(localizeItemSelector, item);
                }
            }
        }

        /// <summary>
        /// Generate NavGroup
        /// </summary>
        /// <param name="localizeItemSelector"></param>
        /// <param name="item"></param>
        private void SetNavBarGroup(LocalizeItemSelector localizeItemSelector, SystemMenuTreeList item)
        {
            NavGroup = new OutlookSection();
            //NavGroup.PageUri = item.PageUri;
            NavGroup.Header = localizeItemSelector.setLocalizeValue(NavGroup, HeaderedContentControl.HeaderProperty);
            if (item.ImageIcon != null)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.CreateOptions = BitmapCreateOptions.None;
                bitmap.CacheOption = BitmapCacheOption.Default;
                var imageSource = item.ImageIcon;
                bitmap.StreamSource = new MemoryStream((byte[])imageSource.ToArray());
                bitmap.EndInit();
                Image image = new Image();
                image.Source = bitmap;
                NavGroup.Image = image.Source;
            }
            //NavGroup.Click += NavGroup_Click;
            NavigationBar.Sections.Add(NavGroup);
            objtree = new TreeView();
            NavGroup.Margin = new Thickness(0,0,0,0);
            objtree.Margin = new Thickness(0, 5, 0, 0);
            NavGroup.Content = objtree;
            //NavigationBar.Items.Add(objtree);
            TreeViewItemEx AreapageItem = new TreeViewItemEx() { Style = objtemplate, IsAreaPageTreeItem = true };//
            LocalizeItemSelector localizeItemSelector1 = new LocalizeItemSelector();
            CommonMethods.AddLocalizeItem(localizeItemSelector1, "en", "Area Page");
            CommonMethods.AddLocalizeItem(localizeItemSelector1, "ja", "エリアページ");
            CommonMethods.AddLocalizeItem(localizeItemSelector1, "th", "หน้าบริเวณ");
            CommonMethods.AddLocalizeItem(localizeItemSelector1, "zh", "區頁");
            //AreapageItem.PageUri = item.PageUri;
            localizeItemSelector1.setLocalizeValue(AreapageItem, TreeViewItemEx.HeaderProperty);
            AreapageItem.Header = localizeItemSelector1.setLocalizeValue(AreapageItem, TreeViewItemEx.HeaderProperty);
            //AreapageItem.MouseLeftButtonUp += new MouseButtonEventHandler(AreapageItem_MouseLeftButtonUp);
            objtree.Items.Add(AreapageItem);
        }

        /// <summary>
        /// Generate TreeViewItem
        /// </summary>
        /// <param name="localizeItemSelector"></param>
        /// <param name="item"></param>
        private void SetNavGroupSubItem(LocalizeItemSelector localizeItemSelector, SystemMenuTreeList item)
        {
            SubItem = new TreeViewItemEx();
            SubItem.Header = localizeItemSelector.setLocalizeValue(SubItem, TreeViewItemEx.HeaderProperty);
            SubItem.Style = objtemplate;

            _dicflattenedTree.Add(item.Id, SubItem);
            SubItem.IsExpanded = true;
            if (_dicflattenedTree.ContainsKey(item.PId))
            {
               //// SubItem.ContextMenu = menuAdd;
                _dicflattenedTree[item.PId].Items.Add(SubItem);
            }
            else
            {
                objtree.Items.Add(SubItem);
            }

            var Col = StructureItemsSource.OrderBy(a => a.DisplayIndex).Where(p => p.PId == item.Id);
            if (0 < Col.Count())
            {
                GenerateNavControlTreeStructure(Col);
            }
            else
            {
                SubItem.PageUri = item.PageUri;
                if (!string.IsNullOrEmpty(item.NameClass))
                {
                    SubItem.MouseEnter += new MouseEventHandler(SubItem_MouseEnter);
                    SubItem.MouseLeftButtonUp += new MouseButtonEventHandler(newItem_MouseLeftButtonUp);
                    SubItem.PreviewKeyDown += new KeyEventHandler(subItemnew_PreviewKeyDown);
                }
            }
        }


        private void subItemnew_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void newItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string AppPath = "pack://application:,,,/AppView;component";
            string ViewPath = (sender as Framework.devControls.TreeViewItemEx).PageUri.ToString();

            (this.tabControl.SelectedItem as DevTabItemEx).NavigateToPage(string.Concat(AppPath,ViewPath));
        }

        private void SubItem_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        #endregion

        /// <summary>
        /// Button Click
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Style objWindow = new System.Windows.Style();
            ResourceDictionary _objStructure = new ResourceDictionary();
            _objStructure.Source = new Uri("pack://application:,,,/Framework.Themes;;component/SkinsShapes/ClassicSkin.xaml", UriKind.Absolute);
            //app.changeSkin("Metro");
            objWindow = (Style)_objStructure["CustSkin"];
            //this.Style = null;CustSkinTemp
            this.Style = objWindow;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.IsWindows8)
            {
                InputPanelConfiguration cp = new InputPanelConfiguration();
                IInputPanelConfiguration icp = cp as IInputPanelConfiguration;
                if (icp != null)
                {
                    icp.EnableFocusTracking();
                }
            }
            //if (this.IsWindows8 == false)
            //{
            //    KeyboardManager.StartOsk();
            //    ////KeyboardManager.LaunchOnScreenKeyboard();
            //}
        }
    }
}
