using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Framework.Data
{
    public static class NavigationCommandsEx
    {
        public static readonly RoutedCommand ForwandCommand = new RoutedCommand("BrowseForward", typeof(NavigationCommandsEx));
        public static RoutedCommand BrowseForward { get { return ForwandCommand; } }

        public static readonly RoutedCommand BackCommand = new RoutedCommand("BrowseBack", typeof(NavigationCommandsEx));
        public static RoutedCommand BrowseBack { get { return BackCommand; } }

        public static readonly RoutedCommand NavigateJournalCommand = new RoutedCommand("NavigateJournal", typeof(NavigationCommandsEx));
        public static RoutedCommand NavigateJournal { get { return NavigateJournalCommand; } }

        public static readonly RoutedCommand RefreshCommand = new RoutedCommand("Refresh", typeof(NavigationCommandsEx));
        public static RoutedCommand Refresh { get { return RefreshCommand; } }
    }
}
