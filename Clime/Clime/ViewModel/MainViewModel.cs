using System;
using System.Collections.ObjectModel;
using System.Windows;
using Clime.MVVMUtils;
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

        public ObservableCollection<Country> Countries { get; set; }

        public MainViewModel(IDataService dataService)
        {
            Countries = new ObservableCollection<Country>();

            _dataService = dataService;
            _dataService.GetCountries(CountriesLoaded);

            ShowAllMeasurementsViewCommand = new RelayCommand(ShowAllMeasurementsView);
            ShowNewMeasurementViewCommand = new RelayCommand(ShowAddNewMeasurementView);
            ShowAboutViewCommand = new RelayCommand(ShowAboutView);

            Messenger.Default.Register<Messages.NewMeasurementAddedMessage>(this, AddedNewMeasurement);
        }

        private static void ShowAllMeasurementsView()
        {
            var newView = new View.AllMeasurementsView();
            newView.ShowDialog();
        }

        private static void ShowAddNewMeasurementView()
        {
            var newView = new View.NewMeasurementView();
            newView.ShowDialog();
        }

        private static void ShowAboutView()
        {
            var newView = new View.AboutView();
            newView.ShowDialog();
        }

        private void CountriesLoaded(CountryRepository countries, Exception error)
        {
            if (error != null)
            {
                Messenger.Default.Send(new DialogMessage(error.ToString(), null) { Button = MessageBoxButton.OK, Caption = "Error" });
                return;
            }

            Countries.Clear();
            foreach (var country in countries.Countries)
            {
                Countries.Add(country);
            }
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