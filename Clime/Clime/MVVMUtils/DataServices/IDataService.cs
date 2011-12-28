using System;
using Clime.Model;

namespace Clime.MVVMUtils.DataServices
{
    interface IDataService
    {
        void GetGeographyRepository(Action<GeographyRepository, Exception> callback);
    }
}
