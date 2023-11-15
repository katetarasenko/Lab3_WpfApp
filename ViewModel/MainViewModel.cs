using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_WpfApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _numberOfObjects;

        public int NumberOfObjects
        {
            get { return _numberOfObjects; }
            set
            {
                if (_numberOfObjects != value)
                {
                    _numberOfObjects = value;
                    OnPropertyChanged(nameof(NumberOfObjects));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
