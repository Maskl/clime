using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Clime.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public RelayCommand ShowMainViewCommand { get; private set; }

        public LoginViewModel()
        {
            ShowMainViewCommand = new RelayCommand(ShowMainView);
        }

        private void ShowMainView()
        {
            var newView = new View.MainView();
            newView.ShowDialog();
        }
    }
}