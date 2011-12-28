using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clime.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);

        void GetCountries(Action<CountryRepository, Exception> callback);
    }
}
