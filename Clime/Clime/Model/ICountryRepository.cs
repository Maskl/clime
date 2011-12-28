using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clime.Model
{
    public interface ICountryRepository
    {
        void Create();

        List<Country> GetAll();
    }
}
