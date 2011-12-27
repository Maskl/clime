using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Clime.ViewModel
{
    public class AllMeasurementsViewModel : ViewModelBase
    {
        public RelayCommand ShowNewMeasurementViewCommand { get; private set; }

        public AllMeasurementsViewModel()
        {
            ShowNewMeasurementViewCommand = new RelayCommand(ShowAddNewMeasurementView);
        }

        private void ShowAddNewMeasurementView()
        {
            var newView = new View.NewMeasurementView();
            newView.ShowDialog();
        }
    }
}