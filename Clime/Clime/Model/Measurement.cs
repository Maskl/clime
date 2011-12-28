using System;
using Clime.MVVMUtils;

namespace Clime.Model
{
    [Serializable]
    class Measurement : Notifier
    {
        private int _temperature;

        public Measurement(int temperature)
        {
            _temperature = temperature;
        }

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                RaisePropertyChanged("Temperature");
            }
        }
    }
}
