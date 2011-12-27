using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace Clime.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            Messenger.Default.Register<string>(this, SaveNewMeasurement);
        }

        private void SaveNewMeasurement(string message)
        {
            if (message.Equals("LoginMessage"))
            {
                var newView = new View.MainView();
                newView.Show();
            }
        }
    }
}