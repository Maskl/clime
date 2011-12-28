using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace Clime.Model
{
    public class CountryRepository : DependencyObject
    {
        private static readonly string[] _dummyCountries = {
                                                     "pl", "Poland", "PolishImage",
                                                     "us", "United States", "USImage",
                                                     "jp", "Japan", "JapanImage",
                                                     "ua", "Ukraine", "UkraineImage",
                                                     "it", "Italy", "ItalyImage",
                                                     "ar", "Argentina", "ArgentinaImage"
                                                 };

        private ObservableCollection<Country> _countries;
        public ObservableCollection<Country> CountriesCollection
        {
            get { return _countries; }
            set { _countries = value; }
        }

        public void Create()
        {
            CountriesCollection = new ObservableCollection<Country>();
            for (int i = 0; i < _dummyCountries.Length; i += 3)
            {
                var c = new Country(_dummyCountries[i], _dummyCountries[i + 1], _dummyCountries[i + 2]);
                CountriesCollection.Add(c);
            }
        }

        public void CreateDummy()
        {
            CountriesCollection = new ObservableCollection<Country>();
            for (int i = 0; i < _dummyCountries.Length; i += 3)
            {
                var c = new Country(_dummyCountries[i], _dummyCountries[i + 1] + " Dummy", _dummyCountries[i + 2]);
                CountriesCollection.Add(c);
            }
        }

        public ObservableCollection<Country> GetAll()
        {
            return CountriesCollection;
        }
    }
}
