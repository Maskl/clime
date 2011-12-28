using System;
using Clime.Model;

namespace Clime.MVVMUtils
{
    public class DesignDataService : IDataService
    {
        public void GetCountries(Action<CountryRepository, Exception> callback)
        {
            var countries = new CountryRepository();
            countries.CreateDummy();
            callback(countries, null);
        }
    }
}