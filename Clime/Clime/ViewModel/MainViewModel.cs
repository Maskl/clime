using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Clime.MVVMUtils;
using Clime.MVVMUtils.DataServices;
using GalaSoft.MvvmLight;
using Clime.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Clime.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public RelayCommand ShowAllMeasurementsViewCommand { get; private set; }
        public RelayCommand ShowNewMeasurementViewCommand { get; private set; }
        public RelayCommand ShowAboutViewCommand { get; private set; }


        private int _selectedContinentId;
        public int SelectedContinentId
        {
            get { return _selectedContinentId; }
            set
            {
                if (_selectedContinentId == value) 
                    return;

                _selectedContinentId = value;

                ContinentFilterSelected();

                RaisePropertyChanged("SelectedContinentId");
            }
        }


        public ObservableCollection<Country> CountriesRaw { get; set; }
        public ObservableCollection<Country> Countries { get; set; }
        public ObservableCollection<string> Continents { get; set; }

        public MainViewModel(IDataService dataService)
        {
            CountriesRaw = new ObservableCollection<Country>();
            Countries = new ObservableCollection<Country>();
            Continents = new ObservableCollection<string>();

            _dataService = dataService;
            _dataService.GetGeographyRepository(GeographyRepositoryLoaded);

            ShowAllMeasurementsViewCommand = new RelayCommand(ShowAllMeasurementsView);
            ShowNewMeasurementViewCommand = new RelayCommand(ShowAddNewMeasurementView);
            ShowAboutViewCommand = new RelayCommand(ShowAboutView);

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

        private bool IsCountryBelongToSelectedContinent(Country country)
        {
            // Meta Continent: "Whole World"
            if (SelectedContinentId == 0)
                return true;

            // Meta Country: "Any Country"
            if (country.ContinentId == ContinentsEnum.Special)
                return true;

            return country.ContinentId == (ContinentsEnum)(SelectedContinentId - 1);
        }

        private void ContinentFilterSelected()
        {
            Countries.Clear();
            foreach (var country in CountriesRaw.Where(IsCountryBelongToSelectedContinent))
            {
                Countries.Add(country);
            }
        }

        private void GeographyRepositoryLoaded(GeographyRepository countries, Exception error)
        {
            if (error != null)
            {
                Messenger.Default.Send(new DialogMessage(error.ToString(), null) { Button = MessageBoxButton.OK, Caption = "Error" });
                return;
            }

            Continents.Clear();
            foreach (var continent in countries.Continents)
            {
                Continents.Add(continent);
            }

            CountriesRaw.Clear();
            foreach (var country in countries.Countries)
            {
                CountriesRaw.Add(country);
            }

            ContinentFilterSelected();
        }

        private static void AddedNewMeasurement(Messages.NewMeasurementAddedMessage message)
        {
            if (message == null)
                return;

            // todo:
            Messenger.Default.Send(new DialogMessage("Added " + message.MeasurementAdded, null) { Button = MessageBoxButton.OK, Caption = "Caption??" });
        }
    }
}