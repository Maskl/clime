using System;
using Clime.Model;

namespace Clime.MVVMUtils.DataServices
{
    public interface IDataService
    {
        void GetGeographyRepository(Action<GeographyRepository, Exception> callback);
    }
}
