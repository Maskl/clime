using System.Windows;
using GalaSoft.MvvmLight.Messaging;

namespace Clime.View
{
    /// <summary>
    /// Description for LoginWindow.
    /// </summary>
    public partial class LoginView : Window
    {
        /// <summary>
        /// Initializes a new instance of the LoginWindow class.
        /// </summary>
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnLoginButton(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string, ViewModel.LoginViewModel>("LoginMessage");
            Close();
        }
    }
}