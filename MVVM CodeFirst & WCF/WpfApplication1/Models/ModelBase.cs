using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WpfApplication1.Models
{
    public class ModelBase : INotifyPropertyChanged, IDataErrorInfo
    {

        private Dictionary<string, string> _errors = new Dictionary<string, string>();

        public virtual bool HasErrors
        {
            get
            {
                return _errors.Count > 0;
            }
        }

        public void SetError(string propertyName, string errorMessage)
        {
            _errors[propertyName] = errorMessage;
            this.OnPropertyChanged(propertyName);
        }

        protected void ClearError(string propertyName)
        {
            this._errors.Remove(propertyName);
        }

        protected void ClearAllErrors()
        {
            List<string> properties = new List<string>();

            foreach (KeyValuePair<string, string> error in this._errors)
            {
                properties.Add(error.Key);
            }
            this._errors.Clear();

            foreach (string property in properties)
            {
                this.OnPropertyChanged(property);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                if (this._errors.ContainsKey(columnName))
                {
                    return this._errors[columnName];
                }
                return string.Empty;
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
