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
        private static readonly string[] DummyCountries = {
                                                     "pl", "Poland", "PolishImage",
                                                     "us", "United States", "USImage",
                                                     "jp", "Japan", "JapanImage",
                                                     "ua", "Ukraine", "UkraineImage",
                                                     "it", "Italy", "ItalyImage",
                                                     "ar", "Argentina", "ArgentinaImage"
                                                 };

        public ObservableCollection<Country> Countries { get; set; }

        public void Create()
        {
            Countries = new ObservableCollection<Country>();
            for (var i = 0; i < DummyCountries.Length; i += 3)
            {
                var c = new Country(DummyCountries[i], DummyCountries[i + 1], DummyCountries[i + 2]);
                Countries.Add(c);
            }
        }

        public void CreateDummy()
        {
            Countries = new ObservableCollection<Country>();
            for (var i = 0; i < DummyCountries.Length; i += 3)
            {
                var c = new Country(DummyCountries[i], DummyCountries[i + 1] + " Dummy", DummyCountries[i + 2]);
                Countries.Add(c);
            }
        }
    }
}
