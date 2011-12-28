using System;
using Clime.Model;

namespace Clime.MVVMUtils
{
    public class DataService : IDataService
    {
        public void GetCountries(Action<CountryRepository, Exception> callback)
        {
            var countries = new CountryRepository();
            countries.Create();
            callback(countries, null);
        }
    }
}