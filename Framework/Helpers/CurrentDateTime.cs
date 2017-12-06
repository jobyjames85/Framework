using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Framework
{
    /// <summary>
    /// Represent the Current DataTime Thread in Screens
    /// </summary>
    public class CurrentDateTime : INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        /// Field for DispatcherTimer
        /// </summary>
        private DispatcherTimer dispatcherTimer;

        /// <summary>
        /// Field for currentTime
        /// </summary>
        private string currentTime;

        /// <summary>
        /// Field for currentState
        /// </summary>
        ////private string currentState;

        /// <summary>
        /// Field for Month
        /// </summary>
        private string currrentMonth;

        /// <summary>
        /// Field for currentYear
        /// </summary>
        private string currentYear;

        /// <summary>
        /// Field for currentDate
        /// </summary>
        private string currentDate;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentDateTime"/> class.
        /// </summary>
        public CurrentDateTime()
        {
            ////this.CurrentState = DateTime.Now.ToString("tt");
            ////this.CurrentTime = DateTime.Now.Hour.ToString("D2") + " " + DateTime.Now.Minute.ToString("D2");
            this.CurrentTime = DateTime.Now.ToShortTimeString();
            ////this.CurrentMonth = DateTime.Now.ToString("MMM");
            this.CurrentYear = DateTime.Now.Date.ToLongDateString();

            ////if (DateTime.Now.Day % 10 == 1)
            ////{
            ////    this.DateValue = "st";
            ////}
            ////else if (DateTime.Now.Day % 10 == 2)
            ////{
            ////    this.DateValue = "nd";
            ////}
            ////else if (DateTime.Now.Day % 10 == 3)
            ////{
            ////    this.DateValue = "rd";
            ////}
            ////else
            ////{
            ////    this.DateValue = "th";
            ////}
            ////this.CurrerntDate = DateTime.Now.Date.Day.ToString();

            this.dispatcherTimer = new DispatcherTimer(
                new TimeSpan(0, 0, 1),
                DispatcherPriority.Normal,
                delegate
                {
                    ////this.CurrentState = DateTime.Now.ToString("tt");
                    ////this.CurrentMonth = DateTime.Now.ToString("MMM");
                    this.CurrentYear = DateTime.Now.Date.ToLongDateString();
                    ////if (DateTime.Now.Day % 10 == 1)
                    ////{
                    ////    this.DateValue = "st";
                    ////}
                    ////else if (DateTime.Now.Day % 10 == 2)
                    ////{
                    ////    this.DateValue = "nd";
                    ////}
                    ////else if (DateTime.Now.Day % 10 == 3)
                    ////{
                    ////    this.DateValue = "rd";
                    ////}
                    ////else
                    ////{
                    ////    this.DateValue = "th";
                    ////}
                    ////this.CurrerntDate = DateTime.Now.Date.Day.ToString();
                    ////this.CurrentTime = DateTime.Now.Hour.ToString("D2") + " " + DateTime.Now.Minute.ToString("D2");
                    this.CurrentTime = DateTime.Now.ToShortTimeString();
                },
                Application.Current.Dispatcher);
        }

        #endregion

        #region Events

        /// <summary>
        /// PropertyChange Event Field
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the Date Value
        /// </summary>
        ////public string DateValue
        ////{
        ////    get
        ////    {
        ////        return this.dateValue;
        ////    }

        ////    set
        ////    {
        ////        this.dateValue = value;
        ////        this.RaisedPropertyChanged("DateValue");
        ////    }
        ////}

        /// <summary>
        /// Gets or sets the CurrentTime
        /// </summary>
        public string CurrentTime
        {
            get
            {
                return this.currentTime;
            }

            set
            {
                this.currentTime = value;
                this.RaisedPropertyChanged("CurrentTime");
            }
        }

        /// <summary>
        /// Gets or sets the CurrentState
        /// </summary>
        ////public string CurrentState
        ////{
        ////    get
        ////    {
        ////        return this.currentState;
        ////    }

        ////    set
        ////    {
        ////        this.currentState = value;
        ////        this.RaisedPropertyChanged("CurrentState");
        ////    }
        ////}

        /// <summary>
        /// Gets or sets the CurrentMonth
        /// </summary>
        public string CurrentMonth
        {
            get
            {
                return this.currrentMonth;
            }

            set
            {
                this.currrentMonth = value;
                this.RaisedPropertyChanged("CurrentMonth");
            }
        }

        /// <summary>
        /// Gets or sets the Date
        /// </summary>
        public string CurrentYear
        {
            get
            {
                return this.currentYear;
            }

            set
            {
                this.currentYear = value;
                this.RaisedPropertyChanged("CurrentYear");
            }
        }

        /// <summary>
        /// Gets or sets the Date
        /// </summary>
        public string CurrerntDate
        {
            get
            {
                return this.currentDate;
            }

            set
            {
                this.currentDate = value;
                this.RaisedPropertyChanged("CurrerntDate");
            }
        }

        #endregion

        #region Private Method

        /// <summary>
        /// Method for property Changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        private void RaisedPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
