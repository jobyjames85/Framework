using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Framework.Controls
{
    public class FrameEx : Frame, IDisposable
    {
        public static bool AllowNavigateOnChangeSet { get; set; }
        internal JournalEntry[] JournalEntryArray;
        #region "Delegate"
        public delegate void ContentChanged(object oldValue, object newValue);
        public event ContentChanged FrameContentChanged;
        #endregion

        #region Dependency Property"


        public string BaseUriPath
        {
            get { return (string)GetValue(BaseUriPathProperty); }
            set { SetValue(BaseUriPathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BaseUriPath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BaseUriPathProperty =
            DependencyProperty.Register("BaseUriPath", typeof(string), typeof(FrameEx), new PropertyMetadata(string.Empty));

        public object FrameContent
        {
            get { return (object)GetValue(FrameContentProperty); }
            set { SetValue(FrameContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FrameContent.  This enables animation, styling, binding, etc...
        /// <summary>
        /// use for refreshed content without using Dispatched -copy of new content
        /// </summary>
        public static readonly DependencyProperty FrameContentProperty =
            DependencyProperty.Register("FrameContent", typeof(object), typeof(FrameEx), new PropertyMetadata(null));

        public bool IsBrowsBackInputGesture
        {
            get { return (bool)GetValue(IsBrowsBackInputGestureProperty); }
            set { SetValue(IsBrowsBackInputGestureProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsBrowsBackInputGesture.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsBrowsBackInputGestureProperty =
            DependencyProperty.Register("IsBrowsBackInputGesture", typeof(bool), typeof(FrameEx), new PropertyMetadata(false, new PropertyChangedCallback(BackWardJesture_Changed)));

        public static void BackWardJesture_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue == true)
            {
                NavigationCommands.BrowseBack.InputGestures.Add(new KeyGesture(Key.Left, ModifierKeys.Alt));
                NavigationCommands.BrowseBack.InputGestures.Add(new KeyGesture(Key.Back));

            }
        }

        #endregion

        #region "Ctor"
        public FrameEx()
        {
            NavigationCommands.BrowseBack.InputGestures.Clear();
            NavigationCommands.Refresh.InputGestures.Clear();

            this.Loaded += FrameEx_Loaded;
            this.Navigating += FrameEx_Navigating;
            this.Navigated += FrameEx_Navigated;
        }

        #endregion

        #region "Event"
        void FrameEx_Loaded(object sender, RoutedEventArgs e)
        {
            ////Grid ParentGrid = LayoutHelper.FindParentObject<Grid>(sender as DependencyObject);
            ////if (ParentGrid != null && !string.IsNullOrEmpty(ThemeManager.ApplicationThemeName))
            ////{
            ////    ThemeManager.SetThemeName(ParentGrid, null); // make first null to avoid issue when we opennew tab from button at that time some times theme not applied
            ////    ThemeManager.SetThemeName(ParentGrid, ThemeManager.ApplicationThemeName);
            ////}
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            BaseUriPath = BaseUri != null ? BaseUri.ToString() : string.Empty;
            FrameContent = newContent;
            FrameContentChanged(oldContent, newContent);
            base.OnContentChanged(oldContent, newContent);
        }

        void FrameEx_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if (JournalEntryArray != null && JournalEntryArray.Any())
            {

                List<JournalEntry> totalCount = this.GetJournalEntry();
                bool flag = false;
                if (totalCount != null)
                {
                    foreach (var journalEntry in JournalEntryArray)
                    {
                        var match = totalCount.Where(p => p.Source == journalEntry.Source);
                        if (!match.Any()) //(!totalCount.Contains(journalEntry))
                        {
                            var selectedPage = journalEntry.GetType().GetField("_keepAliveRoot", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(journalEntry);
                            IDisposable disposable = selectedPage as IDisposable;
                            if (disposable != null)
                            {
                                disposable.Dispose();
                                flag = true;
                            }
                        }
                    }
                }
                if (flag)
                {
                    GC.Collect();
                }
            }
            FrameEx.AllowNavigateOnChangeSet = true;
        }

        void FrameEx_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            if (this.CurrentSource != null)
            {
                if (this.CurrentSource.Equals(e.Uri))
                    Application.Current.MainWindow.Cursor = Cursors.Arrow;
            }
            if (e.NavigationMode == NavigationMode.New)
            {
                var Entry = this.GetJournalEntry();
                if (Entry != null)
                {
                    JournalEntryArray = new JournalEntry[Entry.Count];
                    Entry.CopyTo(JournalEntryArray);
                }
            }
            else
            {
                JournalEntryArray = null;
            }
        }

        #endregion

        #region "Method"

        private List<JournalEntry> GetJournalEntry()
        {
            var _ownJournalScope = typeof(Frame).GetField("_ownJournalScope", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this);
            if (_ownJournalScope == null) return null;

            // Get Frame._ownJournalScope.Journal
            var journal = _ownJournalScope.GetType().GetProperty("Journal", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_ownJournalScope, null);
            if (journal == null) return null;

            Type journalType = journal.GetType();
            List<JournalEntry> totalCount = journalType.GetField("_journalEntryList", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(journal) as List<JournalEntry>;
            return totalCount;
        }
        public void RemoveFirstPageFromJournal(Frame frame, int limitation)
        {
            // Get Frame._ownJournalScope
            var _ownJournalScope = typeof(Frame).GetField("_ownJournalScope", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(frame);
            if (_ownJournalScope == null) return;

            // Get Frame._ownJournalScope.Journal
            var journal = _ownJournalScope.GetType().GetProperty("Journal", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_ownJournalScope, null);
            if (journal == null) return;

            // Get Frame._ownJournalScope.Journal.TotalCount
            // Get Frame._ownJournalScope.Journal.CurrentIndex
            Type journalType = journal.GetType();
            int? totalCount = journalType.GetProperty("TotalCount", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(journal, null) as int?;
            int? currentIndex = journalType.GetProperty("CurrentIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(journal, null) as int?;
            if (totalCount == null || currentIndex == null) return;

            // Check total count, and then remove first entry
            if (limitation <= totalCount && 1 < currentIndex) // current index at minimum might be 1
            {
                const int pageIndexRemoved = 0; // first page in RemoveEntryInternal
                var RemoveEntryInternal = journalType.GetMethod("RemoveEntryInternal", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                RemoveEntryInternal.Invoke(journal, new object[] { pageIndexRemoved }); // remove first entry
            }
        }
        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            //For all objects in history
            var JournalEntryList = this.GetJournalEntry();
            if (JournalEntryList != null)
            {
                foreach (var journalEntry in JournalEntryList)
                {
                    var selectedPage = journalEntry.GetType().GetField("_keepAliveRoot", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(journalEntry);
                    IDisposable disposable = selectedPage as IDisposable;
                    if (disposable != null)
                    {
                        disposable.Dispose();
                    }
                }
            }
            GC.Collect();
        }

        #endregion
    }
}
