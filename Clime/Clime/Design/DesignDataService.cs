using System;
using Clime.Model;

namespace Clime.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }

        public void GetCountries(Action<CountryRepository, Exception> callback)
        {
            var countries = new CountryRepository();
            countries.CreateDummy();
            callback(countries, null);
        }
    }
}