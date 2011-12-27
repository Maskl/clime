using System.Windows;
using GalaSoft.MvvmLight.Messaging;

namespace Clime.View
{
    public partial class NewMeasurementView : Window
    {
        public NewMeasurementView()
        {
            InitializeComponent();
        }

        private void OnOkButton(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<string, ViewModel.NewMeasurementViewModel>("OkClickedMessage");
            Close();
        }
    }
}