using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Arrival.ViewModels
{
    public class CheckInViewModel : INotifyPropertyChanged
    {
        private string _myentry1;
        public string MyEntry1
        {
            get { return _myentry1; }
            set
            {
                _myentry1 = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
