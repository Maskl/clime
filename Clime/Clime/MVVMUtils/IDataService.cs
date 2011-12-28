using System;
using Clime.Model;

namespace Clime.MVVMUtils
{
    public interface IDataService
    {
        void GetCountries(Action<CountryRepository, Exception> callback);
    }
}
