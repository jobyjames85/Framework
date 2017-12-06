using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Framework.devControls.CustomControl
{
    /// <summary>
    /// Interaction logic for ExceptionViewer
    /// </summary>
    public partial class ExceptionViewer : Window
    {
        #region private Field

        /// <summary>
        /// Field for DefaultTitle
        /// </summary>
        private static string defaultTitle;

        /// <summary>
        /// Field for product
        /// </summary>
        private static string product;

        /// <summary>
        /// Field for small
        /// </summary>
        private double small;

        /// <summary>
        /// Field for med
        /// </summary>
        private double med;

        /// <summary>
        /// Field for large
        /// </summary>
        private double large;

        /// <summary>
        /// Field for chromeWidth
        /// </summary>
        private double chromeWidth;

        #endregion

        #region Private Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionViewer"/> class.
        /// </summary>
        /// <param name="headerMessage">Header Message</param>
        /// <param name="e">Exception Parameter</param>
        public ExceptionViewer(string headerMessage, Exception e)
            : this(headerMessage, e, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionViewer"/> class.
        /// </summary>
        /// <param name="headerMessage">Header Message</param>
        /// <param name="e">Exception Parameter</param>
        /// <param name="owner">Owner Window</param>
        public ExceptionViewer(string headerMessage, Exception e, Window owner)
        {
            this.InitializeComponent();
            if (this.treeView1 != null)
            {
                if (owner != null)
                {
                    //// This hopefully makes our window look like it belongs to the main app.
                    this.Style = owner.Style;

                    //// This seems to make the window appear on the same monitor as the owner.
                    this.Owner = owner;

                    this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                }

                if (DefaultPaneBrush != null)
                {
                    treeView1.Background = DefaultPaneBrush;
                }

                docViewer.Background = treeView1.Background;

                //// We use three font sizes.  The smallest is based on whatever the "standard"
                //// size is for the current system/app, taken from an arbitrary control.

                this.small = treeView1.FontSize;
                this.med = this.small * 1.1;
                this.large = this.small * 1.2;

                this.Title = DefaultTitle;

                this.BuildTree(e, headerMessage);
            }
        }

        #endregion

        /// <summary>
        /// Gets or sets the DefaultTitle
        /// </summary>
        public static string DefaultTitle
        {
            get
            {
                if (defaultTitle == null)
                {
                    if (string.IsNullOrEmpty(Product))
                    {
                        defaultTitle = "Error";
                    }
                    else
                    {
                        defaultTitle = "Error - " + Product;
                    }
                }

                return defaultTitle;
            }

            set
            {
                defaultTitle = value;
            }
        }

        /// <summary>
        /// Gets or sets the DefaultPaneBrush
        /// </summary>
        public static Brush DefaultPaneBrush
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the value of the AssemblyProduct attribute of the app.  
        /// If unable to lookup the attribute, returns an empty string.
        /// </summary>
        public static string Product
        {
            get
            {
                if (product == null)
                {
                    product = GetProductName();
                }

                return product;
            }
        }

        /// <summary>
        /// Get ProductName
        /// </summary>
        /// <returns>Return Value</returns>
        private static string GetProductName()
        {
            string result = string.Empty;

            try
            {
                Assembly _appAssembly = GetAppAssembly();

                object[] customAttributes = _appAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);

                if ((customAttributes != null) && (customAttributes.Length > 0))
                {
                    result = ((AssemblyProductAttribute)customAttributes[0]).Product;
                }
            }
            catch (Exception)
            {
            }

            return result;
        }

        /// <summary>
        /// Get Application Assembly
        /// </summary>
        /// <returns>Return Value</returns>
        private static Assembly GetAppAssembly()
        {
            Assembly _appAssembly = null;

            try
            {
                //// This is supposedly how Windows.Forms.Application does it.
                _appAssembly = Application.Current.MainWindow.GetType().Assembly;
            }
            catch (Exception)
            {
            }

            //// If the above didn't work, try less desireable ways to get an assembly.

            if (_appAssembly == null)
            {
                _appAssembly = Assembly.GetEntryAssembly();
            }

            if (_appAssembly == null)
            {
                _appAssembly = Assembly.GetExecutingAssembly();
            }

            return _appAssembly;
        }

        /// <summary>
        /// Render Enumerable
        /// </summary>
        /// <param name="data">Data Parameter</param>
        /// <returns>Return Value</returns>
        private static string RenderEnumerable(IEnumerable data)
        {
            StringBuilder result = new StringBuilder();

            foreach (object obj in data)
            {
                result.AppendFormat("{0}\n", obj);
            }

            if (result.Length > 0)
            {
                result.Length = result.Length - 1;
            }

            return result.ToString();
        }

        /// <summary>
        /// Render Dictionary
        /// </summary>
        /// <param name="data">Data Parameter</param>
        /// <returns>Return Value</returns>
        private static string RenderDictionary(IDictionary data)
        {
            StringBuilder result = new StringBuilder();

            foreach (object key in data.Keys)
            {
                if (key != null && data[key] != null)
                {
                    result.AppendLine(key.ToString() + " = " + data[key].ToString());
                }
            }

            if (result.Length > 0)
            {
                result.Length = result.Length - 1;
            }

            return result.ToString();
        }

        /// <summary>
        /// Window Loaded
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            treeCol.Width = new GridLength(treeCol.ActualWidth, GridUnitType.Pixel);
            this.chromeWidth = this.ActualWidth - mainGrid.ActualWidth;
            this.CalcMaxTreeWidth();
        }

        /// <summary>
        /// Build Tree
        /// </summary>
        /// <param name="e">Exception parameter</param>
        /// <param name="summaryMessage">Summary Message</param>
        private void BuildTree(Exception e, string summaryMessage)
        {
            var inlines = new List<Inline>();
            var firstItem = new TreeViewItem();
            firstItem.Header = "All Messages";
            treeView1.Items.Add(firstItem);

            var inline = new Bold(new Run(summaryMessage));
            inline.FontSize = this.large;
            inlines.Add(inline);

            //// Now add top-level nodes for each exception while building
            //// the contents of the first node.
            while (e != null)
            {
                inlines.Add(new LineBreak());
                inlines.Add(new LineBreak());
                this.AddLines(inlines, e.Message);

                this.AddException(e);
                e = e.InnerException;
            }

            firstItem.Tag = inlines;
            firstItem.IsSelected = true;
        }

        /// <summary>
        /// Add Property
        /// </summary>
        /// <param name="inlines">In Lines </param>
        /// <param name="propName">Property name</param>
        /// <param name="propVal">Property Value</param>
        private void AddProperty(List<Inline> inlines, string propName, object propVal)
        {
            inlines.Add(new LineBreak());
            inlines.Add(new LineBreak());
            var inline = new Bold(new Run(propName + ":"));
            inline.FontSize = this.med;
            inlines.Add(inline);
            inlines.Add(new LineBreak());

            if (propVal is string)
            {
                this.AddLines(inlines, propVal as string);
            }
            else
            {
                inlines.Add(new Run(propVal.ToString()));
            }
        }

        /// <summary>
        /// Add Lines
        /// </summary>
        /// <param name="inlines">In Lines</param>
        /// <param name="str">String Parameter</param>
        private void AddLines(List<Inline> inlines, string str)
        {
            string[] lines = str.Split('\n');

            inlines.Add(new Run(lines[0].Trim('\r')));

            foreach (string line in lines.Skip(1))
            {
                inlines.Add(new LineBreak());
                inlines.Add(new Run(line.Trim('\r')));
            }
        }

        /// <summary>
        /// Add Exception
        /// </summary>
        /// <param name="e">Exception Parameter</param>
        private void AddException(Exception e)
        {
            //// Create a list of Inlines containing all the properties of the exception object.
            //// The three most important properties (message, type, and stack trace) go first.

            var exceptionItem = new TreeViewItem();
            var inlines = new List<Inline>();
            System.Reflection.PropertyInfo[] properties = e.GetType().GetProperties();

            exceptionItem.Header = e.GetType();
            exceptionItem.Tag = inlines;
            treeView1.Items.Add(exceptionItem);

            Inline inline = new Bold(new Run(e.GetType().ToString()));
            inline.FontSize = this.large;
            inlines.Add(inline);

            this.AddProperty(inlines, "Message", e.Message);
            this.AddProperty(inlines, "Stack Trace", e.StackTrace);

            foreach (PropertyInfo info in properties)
            {
                //// Skip InnerException because it will get a whole
                //// top-level node of its own.

                if (info.Name != "InnerException")
                {
                    var value = info.GetValue(e, null);

                    if (value != null)
                    {
                        if (value is string)
                        {
                            if (string.IsNullOrEmpty(value as string))
                            {
                                continue;
                            }
                        }
                        else if (value is IDictionary)
                        {
                            value = RenderDictionary(value as IDictionary);
                            if (string.IsNullOrEmpty(value as string))
                            {
                                continue;
                            }
                        }
                        else if (value is IEnumerable && !(value is string))
                        {
                            value = RenderEnumerable(value as IEnumerable);
                            if (string.IsNullOrEmpty(value as string))
                            {
                                continue;
                            }
                        }

                        if (info.Name != "Message" &&
                            info.Name != "StackTrace")
                        {
                            //// Add the property to list for the exceptionItem.
                            this.AddProperty(inlines, info.Name, value);
                        }

                        //// Create a TreeViewItem for the individual property.
                        var propertyItem = new TreeViewItem();
                        var propertyInlines = new List<Inline>();

                        propertyItem.Header = info.Name;
                        propertyItem.Tag = propertyInlines;
                        exceptionItem.Items.Add(propertyItem);
                        this.AddProperty(propertyInlines, info.Name, value);
                    }
                }
            }
        }

        /// <summary>
        /// treeView1 SelectedItemChanged
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void TreeView1_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            this.ShowCurrentItem();
        }

        /// <summary>
        /// Show CurrentItem
        /// </summary>
        private void ShowCurrentItem()
        {
            if (treeView1.SelectedItem != null)
            {
                var inlines = (treeView1.SelectedItem as TreeViewItem).Tag as List<Inline>;
                var doc = new FlowDocument();

                doc.FontSize = this.small;
                doc.FontFamily = treeView1.FontFamily;
                doc.TextAlignment = TextAlignment.Left;
                doc.Background = docViewer.Background;

                if (chkWrap.IsChecked == false)
                {
                    doc.PageWidth = this.CalcNoWrapWidth(inlines) + 50;
                }

                var para = new Paragraph();
                para.Inlines.AddRange(inlines);
                doc.Blocks.Add(para);
                docViewer.Document = doc;
            }
        }

        /// <summary>
        /// Wrap Width
        /// </summary>
        /// <param name="inlines">In Line</param>
        /// <returns>Return Value</returns>
        private double CalcNoWrapWidth(IEnumerable<Inline> inlines)
        {
            double pageWidth = 0;
            var tb = new TextBlock();
            var size = new Size(double.PositiveInfinity, double.PositiveInfinity);

            foreach (Inline inline in inlines)
            {
                tb.Inlines.Clear();
                tb.Inlines.Add(inline);
                tb.Measure(size);

                if (tb.DesiredSize.Width > pageWidth)
                {
                    pageWidth = tb.DesiredSize.Width;
                }
            }

            return pageWidth;
        }

        /// <summary>
        /// Close Click
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event parameter</param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Copy Click
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            var inlines = new List<Inline>();
            var doc = new FlowDocument();
            var para = new Paragraph();

            doc.FontSize = this.small;
            doc.FontFamily = treeView1.FontFamily;
            doc.TextAlignment = TextAlignment.Left;

            foreach (TreeViewItem treeItem in treeView1.Items)
            {
                if (inlines.Any())
                {
                    //// Put a line of underscores between each exception.

                    inlines.Add(new LineBreak());
                    inlines.Add(new Run("____________________________________________________"));
                    inlines.Add(new LineBreak());
                }

                inlines.AddRange(treeItem.Tag as List<Inline>);
            }

            para.Inlines.AddRange(inlines);
            doc.Blocks.Add(para);

            //// Now place the doc contents on the clipboard in both
            //// rich text and plain text format.

            TextRange range = new TextRange(doc.ContentStart, doc.ContentEnd);
            DataObject data = new DataObject();

            using (Stream stream = new MemoryStream())
            {
                range.Save(stream, DataFormats.Rtf);
                data.SetData(DataFormats.Rtf, Encoding.UTF8.GetString((stream as MemoryStream).ToArray()));
            }

            data.SetData(DataFormats.StringFormat, range.Text);
            Clipboard.SetDataObject(data);

            //// The Inlines that were being displayed are now in the temporary document we just built,
            //// causing them to disappear from the viewer.  This puts them back.

            this.ShowCurrentItem();
        }

        /// <summary>
        /// Wrap Checked
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event parameter</param>
        private void ChkWrap_Checked(object sender, RoutedEventArgs e)
        {
            this.ShowCurrentItem();
        }

        /// <summary>
        /// Wrap Unchecked
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event Parameter</param>
        private void ChkWrap_Unchecked(object sender, RoutedEventArgs e)
        {
            this.ShowCurrentItem();
        }

        /// <summary>
        /// Expression ViewerWindow SizeChanged
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Event parameter</param>
        private void ExpressionViewerWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.WidthChanged)
            {
                this.CalcMaxTreeWidth();
            }
        }

        /// <summary>
        /// Tree Width
        /// </summary>
        private void CalcMaxTreeWidth()
        {
            mainGrid.MaxWidth = this.ActualWidth - this.chromeWidth;
            treeCol.MaxWidth = mainGrid.MaxWidth - textCol.MinWidth;
        }
    }
}
