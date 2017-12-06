using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Framework.devControls
{
    public class TreeViewItemEx : TreeViewItem
    {



        public bool IsAreaPageTreeItem
        {
            get { return (bool)GetValue(IsAreaPageTreeItemProperty); }
            set { SetValue(IsAreaPageTreeItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsAreaPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAreaPageTreeItemProperty =
            DependencyProperty.Register("IsAreaPageTreeItem", typeof(bool), typeof(TreeViewItemEx), new PropertyMetadata(false));



        public String PageUri
        {
            get { return (String)GetValue(PageUriProperty); }
            set { SetValue(PageUriProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PageUri.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PageUriProperty =
            DependencyProperty.Register("PageUri", typeof(String), typeof(TreeViewItemEx), new PropertyMetadata(string.Empty));

        public TreeViewItemEx()
        {

        }
    }
}
