using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication2
{
    public class WindowViewModel : ViewModelBase
    {
        public WindowViewModel()
        {
            CloseSignal = false;
        }

        private bool closeSignal;

        public bool CloseSignal
        {
            get 
            {
                return closeSignal; 
            }
            set
            {
                closeSignal = value;
                OnPropertyChanged("CloseSignal");
            }
        }
        

        private ICommand openCommand;

        public ICommand OpenCommand
        {
            get
            {
                if (this.openCommand == null)
                {
                    this.openCommand = new RelayCommand<object>(this.ExecuteOpen, this.CanExecuteOpen);
                }

                return openCommand;
            }
        }

        private bool CanExecuteOpen(object obj)
        {
            return true;
        }

        private void ExecuteOpen(object win)
        {
            //win.DialogResult = true;
            //win.Close();

            CloseSignal = true;

        }
    }
}
