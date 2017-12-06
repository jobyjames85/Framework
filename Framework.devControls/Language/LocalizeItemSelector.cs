using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace Framework.devControls
{
    public class LocalizeItem
    {
        public LocalizeItem() { }

        public string IetfLanguageTag { get; set; }
        public string Text { get; set; }
    }

    /// <summary>
    /// class contains handlers & switch language
    /// </summary>
    [ContentProperty("Collection")]
    public class LocalizeItemSelector : MarkupExtension
    {

        private ObservableCollection<LocalizeItem> _collection;

        public ObservableCollection<LocalizeItem> Collection
        {
            get
            {
                if (_collection == null)
                    _collection = new ObservableCollection<LocalizeItem>();
                return _collection;
            }
            //set { _collection = value; }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            //Changed by Vipul Thakkar ....
            IProvideValueTarget target = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
            if (null != target && null != target.TargetObject)
            {
                if (target.TargetObject.GetType().FullName == "System.Windows.SharedDp")
                    return this;
            }
            //....

            //const string undifnedLanguage = "*****";

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (var item in _collection)
                dictionary.Add(item.IetfLanguageTag.Substring(0, 2).ToLower(), item.Text);

            DependencyObject targetObject;
            DependencyProperty targetProperty;
            if (!TryGetTargetItems(serviceProvider, out targetObject, out targetProperty)) return null;

            //Default Text settings according to Default language
            XmlLanguage xmlLanguage = null;
            xmlLanguage = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentUICulture.Name);
            //if (targetObject is FrameworkElement)
            //    xmlLanguage = (targetObject as FrameworkElement).Language;
            //string lan = System.Globalization.CultureInfo.CurrentUICulture.Name.ToString();
            //if ((targetObject as FrameworkElement).Language.IetfLanguageTag != lan.ToLower())
            //{
            // Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(lan.ToString());
            // }
            //#if SILVERLIGHT

            //#else
            //else if (targetObject is FrameworkContentElement)
            //    xmlLanguage = (targetObject as FrameworkContentElement).Language;
            //#endif
            if (xmlLanguage == null) return null;

            // <--------------- modified by antony
            string defaultValue;
            dictionary.TryGetValue("en", out defaultValue);

            string value;
            if (!dictionary.TryGetValue(
                xmlLanguage.IetfLanguageTag.Substring(0, 2), out value)) return defaultValue;
            // ---->

            PropertyChangeNotifier languageChangeNotifier = new PropertyChangeNotifier(targetObject, "Language");
            targetObject.SetValue(Behavior.LanguageNotifierProperty, languageChangeNotifier);
            languageChangeNotifier.ValueChanged += ((sender1, e1) =>
            {

                PropertyChangeNotifier propNotifier = sender1 as PropertyChangeNotifier;
                XmlLanguage _xmlLanguage = null;
                if (propNotifier.PropertySource is FrameworkElement)
                    _xmlLanguage = (propNotifier.PropertySource as FrameworkElement).Language;
#if SILVERLIGHT

#else

                else if (propNotifier.PropertySource is FrameworkContentElement)
                    _xmlLanguage = (propNotifier.PropertySource as FrameworkContentElement).Language;
#endif
                if (_xmlLanguage != null && !string.IsNullOrEmpty(_xmlLanguage.IetfLanguageTag))
                {
                    string _value;
                    if (dictionary.TryGetValue(_xmlLanguage.IetfLanguageTag.Substring(0, 2), out _value))
                        propNotifier.PropertySource.SetValue(targetProperty, _value);
                    else
                        propNotifier.PropertySource.SetValue(targetProperty, value);
                }
            });
            targetObject = null;

            return value;
        }

        protected virtual bool TryGetTargetItems(IServiceProvider provider, out DependencyObject target, out DependencyProperty dp)
        {
            target = null;
            dp = null;
            if (provider == null) return false;

            //create a binding and assign it to the target
            IProvideValueTarget service = (IProvideValueTarget)provider.GetService(typeof(IProvideValueTarget));
            if (service == null) return false;
            target = service.TargetObject as DependencyObject;
            //we need dependency objects / properties
#if SILVERLIGHT

            PropertyInfo propinfo = service.TargetProperty as PropertyInfo;
            dp = GetDependencyProperty(propinfo.DeclaringType, propinfo.Name);
#else
            dp = service.TargetProperty as DependencyProperty;
#endif
            return target != null && dp != null;
        }

        public static DependencyProperty GetDependencyProperty(Type type, string name)
        {
            FieldInfo fieldInfo = type.GetField(name + "Property", BindingFlags.Public | BindingFlags.Static);
            return (fieldInfo != null) ? (DependencyProperty)fieldInfo.GetValue(null) : null;
        }

        public string setLocalizeValue(DependencyObject depObj, DependencyProperty depProperty)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (var item in Collection)
                dictionary.Add(item.IetfLanguageTag.Substring(0, 2).ToLower(), item.Text);

            DependencyObject targetObject;
            DependencyProperty targetProperty;
            targetObject = depObj;// as NavBarGroup;
            targetProperty = depProperty;// NavBarGroup.HeaderProperty;



            //Default Text settings according to Default language
            XmlLanguage xmlLanguage = null;
            if (targetObject is FrameworkElement)
                xmlLanguage = (targetObject as FrameworkElement).Language;
#if SILVERLIGHT

#else
            else if (targetObject is FrameworkContentElement)
                xmlLanguage = (targetObject as FrameworkContentElement).Language;
#endif
            //if (xmlLanguage == null) return null;

            string value;
            dictionary.TryGetValue(xmlLanguage.IetfLanguageTag.Substring(0, 2), out value);

            PropertyChangeNotifier languageChangeNotifier = new PropertyChangeNotifier(targetObject, "Language");
            targetObject.SetValue(Behavior.LanguageNotifierProperty, languageChangeNotifier);
            languageChangeNotifier.ValueChanged += ((sender1, e1) =>
            {
                PropertyChangeNotifier propNotifier = sender1 as PropertyChangeNotifier;
                XmlLanguage _xmlLanguage = null;
                if (propNotifier.PropertySource is FrameworkElement)
                    _xmlLanguage = (propNotifier.PropertySource as FrameworkElement).Language;
#if SILVERLIGHT

#else
                else if (propNotifier.PropertySource is FrameworkContentElement)
                    _xmlLanguage = (propNotifier.PropertySource as FrameworkContentElement).Language;
#endif
                if (_xmlLanguage != null && !string.IsNullOrEmpty(_xmlLanguage.IetfLanguageTag))
                {
                    string _value;
                    if (dictionary.TryGetValue(_xmlLanguage.IetfLanguageTag.Substring(0, 2), out _value))
                        propNotifier.PropertySource.SetValue(targetProperty, _value);
                    else
                        propNotifier.PropertySource.SetValue(targetProperty, value);
                }
            });
            targetObject = null;
            return value;
        }
    }
}
