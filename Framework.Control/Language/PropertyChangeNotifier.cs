using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Framework.Controls
{
    [Serializable]
    public sealed class PropertyChangeNotifier : DependencyObject, IDisposable, INotifyPropertyChanged
    {
        #region Member Variables
        private WeakReference _propertySource;
        #endregion // Member Variables

        #region Constructor
        public PropertyChangeNotifier(DependencyObject propertySource, string path)
            : this(propertySource, new PropertyPath(path))
        {

        }

        public PropertyChangeNotifier(DependencyObject propertySource, DependencyProperty property)
            : this(propertySource, new PropertyPath(property))
        {

        }
        public PropertyChangeNotifier(DependencyObject propertySource, PropertyPath property)
        {
            if (null == propertySource)
                throw new ArgumentNullException("propertySource");
            if (null == property)
                throw new ArgumentNullException("property");
            this._propertySource = new WeakReference(propertySource);
            Binding binding = new Binding() { Path = property, Mode = BindingMode.OneWay, Source = propertySource };
            BindingOperations.SetBinding(this, ValueProperty, binding);
        }
        #endregion // Constructor
        //Value={Binding NumberOfPlayers, Mode=TwoWay, NotifyOnValidationError=true, ValidatesOnExceptions=true, RelativeSource={RelativeSource Mode=FindAncestor, AncestorType={x:Type YourNamespace:YourTypeContainingChipsetProperty}}}


        #region PropertySource
        public DependencyObject PropertySource
        {
            get
            {
                try
                {
                    // note, it is possible that accessing the target property
                    // will result in an exception so i’ve wrapped this check
                    // in a try catch
                    return this._propertySource.IsAlive
                    ? this._propertySource.Target as DependencyObject
                     : null;
                }
                catch
                {
                    return null;
                }
            }
        }
        #endregion // PropertySource

        #region Value
        /// <summary>
        /// Identifies the <see cref=”Value”/> dependency property
        /// </summary>
        //public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value",
        //        typeof(object), typeof(PropertyChangeNotifier), new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnPropertyChanged)));
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value",
                typeof(object), typeof(PropertyChangeNotifier), new PropertyMetadata(null, new PropertyChangedCallback(OnPropertyChanged)));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PropertyChangeNotifier notifier = (PropertyChangeNotifier)d;
            if (null != notifier.ValueChanged)
                notifier.ValueChanged(notifier, EventArgs.Empty);
        }

        /// <summary>
        /// Returns/sets the value of the property
        /// </summary>
        /// <seealso cref=”ValueProperty”/>
        [Description("Returns/sets the value of the property")]
        [Category("Behavior")]
        [Bindable(true)]
        public object Value
        {
            get
            {
                return (object)this.GetValue(PropertyChangeNotifier.ValueProperty);
            }
            set
            {
                this.SetValue(PropertyChangeNotifier.ValueProperty, value);
            }
        }
        #endregion //Value

        #region Events
        public event EventHandler ValueChanged;
        #endregion // Events

        #region IDisposable Members
        public void Dispose()
        {
#if SILVERLIGHT
            this.ClearValue(ValueProperty);
#else
            BindingOperations.ClearBinding(this, ValueProperty);
#endif
        }
        #endregion




        #region INotifyPropertyChanged Members
#if !SILVERLIGHT
        [field: NonSerialized]
#endif
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }

    public class ChangeLanguage : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string lan = System.Globalization.CultureInfo.CurrentUICulture.Name.ToString();
                if (((System.Windows.Markup.XmlLanguage)(value)).IetfLanguageTag != lan.ToLower())
                {
                    string sDefaultLocalization = lan.ToString();
                    Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(sDefaultLocalization);
                    return XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentCulture.Name);
                }

                return value;
            }
            else
                return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
