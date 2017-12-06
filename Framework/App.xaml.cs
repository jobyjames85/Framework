//-----------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="ActySystem">
//     Copyright (c) Acty System India Pvt. Ltd.  All rights reserved.
// </copyright>
//---------------------------------------------------------------------------
namespace Framework
{
    using AppModel.Model;
    using AppView.Interface;
    using Microsoft.Practices.EnterpriseLibrary.SemanticLogging;
    using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Sinks;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.Tracing;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App
    /// </summary>
    public partial class App : Application
    {
        ResourceDictionary rd = new ResourceDictionary();
        public string SqlServerName { get; set; }
        public string DatabaseName { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        /// <summary>
        ///  Field for isTerminalNameVisible
        /// </summary>
        private static bool isTerminalNameVisible;
        public static bool IsTerminalNameVisible
        {
            get
            {
                return isTerminalNameVisible;
            }

            set
            {
                if (value != isTerminalNameVisible)
                {
                    isTerminalNameVisible = value;
                    NotifyStaticPropertyChanged("IsTerminalNameVisible");
                }
            }
        }
        /// <summary>
        /// Gets the Log File Size In KB
        /// </summary>
        public static int LogFileSizeInKb
        {
            get
            {
                int result = 100;
                string size = "300";
                int.TryParse(size, out result);

                return result;
            }
        }

        /// <summary>
        /// Gets the Number Of Log File Archives
        /// </summary>
        public static int NumberOfLogFileArchives
        {
            get
            {
                int result = 10;
                string size = "10";
                int.TryParse(size, out result);

                return result;
            }
        }
        // <summary>
        /// Static Event Property update
        /// </summary>
        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;
        // <summary>
        /// Notify Static PropertyChanged
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public static void NotifyStaticPropertyChanged(string propertyName)
        {
            if (StaticPropertyChanged != null)
            {
                StaticPropertyChanged(null, new PropertyChangedEventArgs(propertyName));
            }
        }
        /// <summary>
        /// OnStartup
        /// </summary>
        /// <param name="e">Startup Event</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            SqlServerName = "FTS-DSK-101";
            DatabaseName = "FrameworkData";
            IntegratedSecurity = true;
            UserId = string.Empty;
            Password = string.Empty;
            TryCreateNewDatabase(SqlServerName, DatabaseName, IntegratedSecurity, UserId, Password);
            string txtpath = "E:/LogInfo.txt";
            var logListener = RollingFlatFileLog.CreateListener(txtpath, LogFileSizeInKb, "MMM-dd-yyyy hh-mm-ss", RollFileExistsBehavior.Increment, RollInterval.None, new LogEntryTextFormatter("/********************************/", "/+++++++++++++++++++++++++++++++/", EventLevel.LogAlways, "MMM-dd-yyyy hh:mm:ss"), NumberOfLogFileArchives);
            logListener.EnableEvents(WpfLogger.Log, System.Diagnostics.Tracing.EventLevel.LogAlways, System.Diagnostics.Tracing.EventKeywords.None);
        }

        private bool TryCreateNewDatabase(string serverName, string Database, bool IntegratedSecurity, string UserID, string Password)
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = Database;
            sqlBuilder.MultipleActiveResultSets = true;
            if (IntegratedSecurity)
            {
                sqlBuilder.IntegratedSecurity = true;
            }
            else
            {
                sqlBuilder.UserID = UserID;
                sqlBuilder.Password = Password;
            }

            Entities1.DefaultConnectionString = sqlBuilder.ToString();
            Entities1.DefaultCommandTimeoutSeconds = 300;

            using (Entities1 dc = new Entities1())
            {
                //dc.Database.CreateIfNotExists();
                //dc.Database.Initialize(true);
                dc.Database.Connection.Open();
            }
            return true; // no exception, database created, success
        }

        public void changeSkin(string themePath)
        {
            rd.MergedDictionaries.Clear();

            if (!string.IsNullOrEmpty(themePath))
            {
                    //Added for blink in the control data change in GridcontrolEx
                    rd.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,/Framework.Themes;component/Themes/CommonStyle.xaml", UriKind.Absolute) });
                    rd.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,/Framework.Themes;component/Themes/SystemButtonStyle.xaml", UriKind.Absolute) });    
                    rd.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,/Framework.Themes;component/SkinColor/BlueColorSkin.xaml", UriKind.Absolute) });
                    rd.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,/Framework.Themes;component/SkinsShapes/ClassicSkin.xaml", UriKind.Absolute) });
            }

            Resources = rd;
        }

        /// <summary>
        /// Application DispatcherUnhandledException
        /// </summary>
        /// <param name="sender">Sender Parameter</param>
        /// <param name="e">Dispatcher Unhandled ExceptionEvent</param>
        private void Application_DispatcherUnhandledException_1(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            WpfLogger.Log.Error(e.Exception.ToString());
            e.Handled = true;
        }

        /// <summary>
        /// Language Change
        /// </summary>
        /// <param name="currentCulture">Culture Name</param>
        public void LanguageChange(string currentCulture)
        {
            if (!string.IsNullOrEmpty(currentCulture))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(currentCulture);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentCulture);

                foreach (var item in this.Windows)
                {
                    var language = item as ILanguageChange;
                    if (language != null)
                    {
                        language.LanguageChanged(currentCulture);
                    }
                    ////(item as dynamic).LanguageChanged(currentCulture);
                }
            }
        }

        private static string blueSkin = "pack://application:,,,/project;component/Resources/Skins/BlueSkin.xaml";

        /// <summary>
        /// Field for OrangeSkin
        /// </summary>
        private static string orangeSkin = "pack://application:,,,/project;component/Resources/Skins/OrangeSkin.xaml";

        private ResourceDictionary resourceDictionary;
        /// <summary>
        /// Theme Change
        /// </summary>
        /// <param name="themeName">Theme Name</param>
        public void ThemeChange(string themeName)
        {
            ResourceDictionary dictionary;
            if (Theme.Blue.ToString() == themeName)
            {
                dictionary = new ResourceDictionary();
                dictionary.Source = new Uri(blueSkin, UriKind.RelativeOrAbsolute);
            }
            else
            {
                dictionary = new ResourceDictionary();
                dictionary.Source = new Uri(orangeSkin, UriKind.RelativeOrAbsolute);
            }

            if (this.resourceDictionary != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(this.resourceDictionary);
                this.resourceDictionary = dictionary;
                Application.Current.Resources.MergedDictionaries.Add(this.resourceDictionary);
            }
            else
            {
                this.resourceDictionary = dictionary;
                Application.Current.Resources.MergedDictionaries.Add(this.resourceDictionary);
            }
        }

    }
}


//var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//            if (!Directory.Exists(Path.Combine(path, V_Parcel.Properties.Resources.VParcel)))
//            {
//                Directory.CreateDirectory(Path.Combine(path, V_Parcel.Properties.Resources.VParcel));
//            }

// this.SetSettingsFile(path);

//          /// <summary>
//         /// Set Settings File
//         /// </summary>
//        /// <param name="path">Url Path</param>
//        private void SetSettingsFile(string path)
//        {
//            if (File.Exists(Path.Combine(path, V_Parcel.Properties.Resources.VParcel) + @"/SettingsFile.xml"))
//            {
//                XmlDocument xmlDoc = new XmlDocument();
//                xmlDoc.Load(Path.Combine(path, V_Parcel.Properties.Resources.VParcel) + @"/SettingsFile.xml");
//                XmlNodeList nodelist = xmlDoc.SelectNodes("Settings");
//                XmlNode nodeItems = nodelist.Item(0);
//                App.UrlPath = nodeItems.ChildNodes.Item(0).InnerText;
//                App.UserName = nodeItems.ChildNodes.Item(1).InnerText;
//                App.Password = nodeItems.ChildNodes.Item(2).InnerText;
//                App.Country = nodeItems.ChildNodes.Item(3).InnerText;
//                App.Hub = nodeItems.ChildNodes.Item(4).InnerText;
//                App.Location = nodeItems.ChildNodes.Item(5).InnerText;
//                App.TerminalName = nodeItems.ChildNodes.Item(6).InnerText;
//                App.TerminalGuid = nodeItems.ChildNodes.Item(7).InnerText;
//                if (nodeItems.ChildNodes.Item(8) != null)
//                {
//                    App.CountryCode = nodeItems.ChildNodes.Item(8).InnerText;
//                }

//                if (nodeItems.ChildNodes.Item(9) != null)
//                {
//                    App.HubCode = nodeItems.ChildNodes.Item(9).InnerText;
//                }

//                if (nodeItems.ChildNodes.Item(10) != null)
//                {
//                    App.LocationCode = nodeItems.ChildNodes.Item(10).InnerText;
//                }

//                if (nodeItems.ChildNodes.Item(11) != null)
//                {
//                    App.CurrentCulture = nodeItems.ChildNodes.Item(11).InnerText;
//                }
//            }
//            else
//            {
//                using (XmlTextWriter xmlWriter = new XmlTextWriter(Path.Combine(path, V_Parcel.Properties.Resources.VParcel) + @"/SettingsFile.xml", System.Text.Encoding.UTF8))
//                {
//                    xmlWriter.Formatting = Formatting.Indented;
//                    xmlWriter.WriteStartDocument();
//                    xmlWriter.WriteComment("Settings XML file");
//                    xmlWriter.WriteStartElement("Settings");
//                    xmlWriter.WriteStartElement("UrlPath");
//                    App.UrlPath = "value not set";
//                    xmlWriter.WriteString(App.UrlPath);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("UserName");
//                    App.UserName = "value not set";
//                    xmlWriter.WriteString(App.UserName);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("Password");
//                    App.Password = string.Empty;
//                    xmlWriter.WriteString(App.Password);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("Country");
//                    App.Country = "value not set";
//                    xmlWriter.WriteString(App.Country);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("Hub");
//                    App.Hub = "value not set";
//                    xmlWriter.WriteString(App.Hub);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("Location");
//                    App.Location = "value not set";
//                    xmlWriter.WriteString(App.Location);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("TerminalName");
//                    App.TerminalName = "value not set";
//                    xmlWriter.WriteString(App.TerminalName);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("TerminalGuid");
//                    App.TerminalGuid = "value not set";
//                    xmlWriter.WriteString(App.TerminalGuid);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("CountryCode");
//                    App.CountryCode = "value not set";
//                    xmlWriter.WriteString(App.CountryCode);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("HubCode");
//                    App.HubCode = "value not set";
//                    xmlWriter.WriteString(App.HubCode);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("LocationCode");
//                    App.LocationCode = "value not set";
//                    xmlWriter.WriteString(App.LocationCode);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteStartElement("CurrentCulture");
//                    App.CurrentCulture = "en-US";
//                    xmlWriter.WriteString(App.CurrentCulture);
//                    xmlWriter.WriteEndElement();

//                    xmlWriter.WriteEndElement();
//                    xmlWriter.Flush();
//                    xmlWriter.Close();
//                }
//            }
//        }
//XmlDocument doc = new XmlDocument();
//            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//            doc.Load(Path.Combine(path, Properties.Resources.ProjectFolder) + Properties.Resources.SettingPath);
//            XmlNode urlPath = doc.DocumentElement["UrlPath"];
//            string uripath = urlPathParam.ToString().LastOrDefault().ToString();
//            this.UriPath(urlPathParam, uripath);
//            urlPath.InnerText = App.UrlPath;

//            XmlNode userName = doc.DocumentElement["UserName"];
//            App.UserName = userNameParam;
//            userName.InnerText = userNameParam;

//            XmlNode password = doc.DocumentElement["Password"];
//            App.Password = passwordParam;
//            password.InnerText = passwordParam;

//            if (countryNameParam != null)
//            {
//                XmlNode country = doc.DocumentElement["Country"];
//                App.Country = countryNameParam.CountryName;
//                country.InnerText = countryNameParam.CountryName;

//                XmlNode countryCode = doc.DocumentElement["CountryCode"];
//                App.CountryCode = countryNameParam.CountryCode;
//                countryCode.InnerText = countryNameParam.CountryCode;

//                XmlNode currentCulture = doc.DocumentElement["CurrentCulture"];
//                App.CurrentCulture = countryNameParam.CountryCulture;
//                currentCulture.InnerText = countryNameParam.CountryCulture;

//                ((App)Application.Current).LanguageChange(countryNameParam.CountryCulture);
//            }

//            if (hubNameParam != null)
//            {
//                XmlNode hub = doc.DocumentElement["Hub"];
//                App.Hub = hubNameParam.HubName;
//                hub.InnerText = hubNameParam.HubName;

//                XmlNode hubCode = doc.DocumentElement["HubCode"];
//                App.HubCode = hubNameParam.HubId.ToString();
//                hubCode.InnerText = hubNameParam.HubId.ToString();
//            }

//            if (locationName != null)
//            {
//                XmlNode location = doc.DocumentElement["Location"];
//                App.Location = locationName.LocationName;
//                location.InnerText = locationName.LocationName;

//                XmlNode locationCode = doc.DocumentElement["LocationCode"];
//                App.LocationCode = locationName.LocationID.ToString();
//                locationCode.InnerText = locationName.LocationID.ToString();
//            }

//            if (terminalName != null)
//            {
//                XmlNode terminalNames = doc.DocumentElement["TerminalName"];
//                App.TerminalName = terminalName.TerminalName;
//                terminalNames.InnerText = terminalName.TerminalName;

//                XmlNode terminalGuid = doc.DocumentElement["TerminalGuid"];
//                App.TerminalGuid = terminalName.LockerTerminalID.ToString();
//                terminalGuid.InnerText = terminalName.LockerTerminalID.ToString();
//            }

//            doc.Save(Path.Combine(path, Properties.Resources.ProjectFolder) + Properties.Resources.SettingPath);