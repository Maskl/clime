using System;

namespace Clime.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Welcome to MVVM Light");
            callback(item, null);
        }

        public void GetCountries(Action<CountryRepository, Exception> callback)
        {
            var countries = new CountryRepository();
            countries.Create();
            callback(countries, null);
        }
    }
}