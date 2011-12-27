using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Clime.ViewModel
{
    public class NewMeasurementViewModel : ViewModelBase
    {
        public NewMeasurementViewModel()
        {
            Messenger.Default.Register<string>(this, SaveNewMeasurement);
        }

        private void SaveNewMeasurement(string message)
        {
            if (message.Equals("OkClickedMessage"))
            {
                var guid = AddMeasurementToDataBase();

                // Send information about new measurement to MainViewModel
                Messenger.Default.Send(new Messages.NewMeasurementAddedMessage(guid));
            }
        }

        private Guid? AddMeasurementToDataBase()
        {
            // todo
            return Guid.NewGuid();
        }
    }
}