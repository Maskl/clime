using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight;
using Clime.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Clime.ViewModel
{
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

        public const string CountriesPropertyName = "Countries";
        private CountryRepository _countries = null;
        public CountryRepository Countries
        {
            get
            {
                return _countries;
            }

            set
            {
                if (_countries == value)
                {
                    return;
                }

                _countries = value;
                RaisePropertyChanged(CountriesPropertyName);
            }
        }



        public ObservableCollection<Country> CountriesY
        {
            get
            {
                return (_countries == null) ? null : _countries.Countries;
            }
        }


        private static readonly string[] _dummyCountries = {
                                                     "aa", "aaaa", "aaaaaas",
                                                     "bb", "bbbb States", "bbas",
                                                 };

        public ObservableCollection<Country> CountriesX { get; set; }

        public void Create()
        {
            CountriesX = new ObservableCollection<Country>();
            for (int i = 0; i < _dummyCountries.Length; i += 3)
            {
                var c = new Country(_dummyCountries[i], _dummyCountries[i + 1], _dummyCountries[i + 2]);
                CountriesX.Add(c);
            }
        }


        public MainViewModel(IDataService dataService)
        {
            CountriesX = null;
            Create();

            _dataService = dataService;
            _dataService.GetCountries(
                (countries, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    CountriesX.Clear();
                    foreach (var country in countries.Countries)
                    {
                        CountriesX.Add(country);
                    }
                });

            ShowAllMeasurementsViewCommand = new RelayCommand(ShowAllMeasurementsView);
            ShowNewMeasurementViewCommand = new RelayCommand(ShowAddNewMeasurementView);
            ShowAboutViewCommand = new RelayCommand(ShowAboutView);

            // We expect a message with some lists with changes.
            Messenger.Default.Register<Messages.NewMeasurementAddedMessage>(this, AddedNewMeasurement);
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

        private void AddedNewMeasurement(Messages.NewMeasurementAddedMessage message)
        {
            if (message == null)
                return;

            // todo:
            Messenger.Default.Send(new DialogMessage("Added " + message.MeasurementAdded, null) { Button = MessageBoxButton.OK, Caption = "Caption??" });
        }
    }
}