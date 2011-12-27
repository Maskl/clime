using GalaSoft.MvvmLight;
using Clime.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Clime.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public RelayCommand ShowAllMeasurementsViewCommand { get; private set; }
        public RelayCommand ShowNewMeasurementViewCommand { get; private set; }
        public RelayCommand ShowAboutViewCommand { get; private set; }

        public const string WelcomeTitlePropertyName = "WelcomeTitle";
        private string _welcomeTitle = string.Empty;
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }

            set
            {
                if (_welcomeTitle == value)
                {
                    return;
                }

                _welcomeTitle = value;
                RaisePropertyChanged(WelcomeTitlePropertyName);
            }
        }

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                });

            ShowAllMeasurementsViewCommand = new RelayCommand(ShowAllMeasurementsView);
            ShowNewMeasurementViewCommand = new RelayCommand(ShowAddNewMeasurementView);
            ShowAboutViewCommand = new RelayCommand(ShowAboutView);

            // We expect a message with some lists with changes.
         //   Messenger.Default.Register<CategoryEditorChangesMessage>(this, MakingNewCatChanges);
        }

        private void ShowAllMeasurementsView()
        {
            var newView = new View.AllMeasurementsView();
            newView.ShowDialog();
        }

        private void ShowAddNewMeasurementView()
        {
            var newView = new View.NewMeasurementView();
            newView.ShowDialog();
        }

        private void ShowAboutView()
        {
            var newView = new View.AboutView();
            newView.ShowDialog();
        }

        private void ShowMainView()
        {
            var newView = new View.MainView();
            newView.ShowDialog();
        }


        public override void Cleanup()
        {
            // Clean up if needed
            base.Cleanup();
        }
    }
}