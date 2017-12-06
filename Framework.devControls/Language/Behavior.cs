using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Framework.devControls
{
    public class Behavior
    {
        public static bool GetDisabledOnDataContextNull(DependencyObject obj)
        {
            if (null != obj)
                return (bool)obj.GetValue(DisabledOnDataContextNullProperty);
            else
                return false;
        }

        public static void SetDisabledOnDataContextNull(DependencyObject obj, bool value)
        {
            if (null != obj)
                obj.SetValue(DisabledOnDataContextNullProperty, value);
        }

        // Using a DependencyProperty as the backing store for DisableOnUnbind.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledOnDataContextNullProperty =
            DependencyProperty.RegisterAttached("DisabledOnDataContextNull", typeof(bool), typeof(Behavior), new PropertyMetadata(false, DisabledOnDataContextNullPropertyChangedCallback));

        protected static void DisabledOnDataContextNullPropertyChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //  LayoutGroup layoutGroup = ((LayoutGroup)sender);
            //Quick Fix Added by Antony
            //  if (layoutGroup.DataContext == null)
            // layoutGroup.IsEnabled = false;
            // else
            //layoutGroup.IsEnabled = true;

            // call handler when DataContext property changed
            //TypeDescriptor.GetProperties(
            //    layoutGroup.GetType())["DataContext"].AddValueChanged(layoutGroup, (sender1, e1) =>
            //    {
            //        if (layoutGroup.DataContext == null)
            //            layoutGroup.IsEnabled = false;
            //        else
            //            layoutGroup.IsEnabled = true;
            //    });
        }

        public static bool GetIsAlwaysEditable(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsAlwaysEditableProperty);
        }

        public static void SetIsAlwaysEditable(DependencyObject obj, bool value)
        {
            obj.SetValue(IsAlwaysEditableProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsAlwaysEditable.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAlwaysEditableProperty =
            DependencyProperty.RegisterAttached("IsAlwaysEditable", typeof(bool), typeof(Behavior), new UIPropertyMetadata(false));

        /// <summary>
        /// IsNonEditable Property To check whether the page allows to Add Update 
        /// Delete Or Editing in Page Level Controls 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool GetIsPageEditable(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsPageEditable);
        }

        public static void SetIsPageEditable(DependencyObject obj, bool value)
        {
            obj.SetValue(IsPageEditable, value);
        }

        // Using a DependencyProperty as the backing store for IsNonEditablePage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPageEditable =
            DependencyProperty.RegisterAttached("IsPageEditable", typeof(bool), typeof(Behavior), new UIPropertyMetadata(true));

        public static bool GetIsToolBar(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsToolBarProperty);
        }

        public static void SetIsToolBar(DependencyObject obj, bool value)
        {
            obj.SetValue(IsToolBarProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsToolBar.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsToolBarProperty =
            DependencyProperty.RegisterAttached("IsToolBar", typeof(bool), typeof(Behavior), new UIPropertyMetadata(true));

        public static PropertyChangeNotifier GetLanguageNotifier(DependencyObject obj)
        {
            return (PropertyChangeNotifier)obj.GetValue(LanguageNotifierProperty);
        }

        public static void SetLanguageNotifier(DependencyObject obj, PropertyChangeNotifier value)
        {
            obj.SetValue(LanguageNotifierProperty, value);
        }

        // Using a DependencyProperty as the backing store for LanguageNotifier.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LanguageNotifierProperty =
            DependencyProperty.RegisterAttached("LanguageNotifier", typeof(PropertyChangeNotifier), typeof(Behavior), new PropertyMetadata(null));
    }
}
