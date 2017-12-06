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
    /// Interaction logic for ComboBoxWithFilter.xaml
    /// </summary>
    public partial class ComboBoxWithFilter : ComboBox
    {
        public ComboBoxWithFilter()
        {
            InitializeComponent();
        }

        private object selectedValue;

        protected void ComboBox_DropDownOpened(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            if (cbo.SelectedValue != null)
            {
                selectedValue = cbo.SelectedValue;
            }
        }

        protected void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            TextBox filterBox = cbo.Template.FindName("DropDownFilterTextBox", cbo) as TextBox;

            if (filterBox != null)
            {
                filterBox.Text = String.Empty;
                selectedValue = null;
            }
        }

        protected void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            TextBox filterBox = cbo.Template.FindName("DropDownFilterTextBox", cbo) as TextBox;

            if (filterBox != null)
            {
                filterBox.TextChanged += new TextChangedEventHandler(DropDownFilterTextBox_TextChanged);
                filterBox.KeyDown += new KeyEventHandler(DropDownFilterTextBox_KeyDown);
            }
        }

        protected void DropDownFilterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            List<Key> capturedKeys = new List<Key>() { Key.Down, Key.Escape };

            if (capturedKeys.Contains(e.Key))
            {
                TextBox filterBox = ((TextBox)sender);
                ComboBox cbo = filterBox.TemplatedParent as ComboBox;

                switch (e.Key)
                {
                    case Key.Escape:
                        filterBox.Text = String.Empty;
                        cbo.SelectedValue = selectedValue;
                        break;
                    case Key.Down:
                        ItemsPresenter itemsPresenter = cbo.Template.FindName("ItemsPresenter", cbo) as ItemsPresenter;
                        itemsPresenter.Focus();
                        break;
                }
            }
        }

        protected void DropDownFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = ((TextBox)sender);

            ComboBox cbo = ((TextBox)sender).TemplatedParent as ComboBox;
            cbo.Items.Filter += a =>
            {
                if (a.ToString().ToLower().StartsWith(textBox.Text.ToLower()))
                {
                    return true;
                }
                return false;
            };
        }

        private void DropDownFilterTextBox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            TextBox textBox = ((TextBox)sender);
            textBox.Focus();
            e.Handled = true;
        }
    }
}
