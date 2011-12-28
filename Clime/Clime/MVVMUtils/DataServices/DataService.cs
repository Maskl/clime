using System;
using Clime.Model;

namespace Clime.MVVMUtils.DataServices
{
    class DataService : IDataService
    {
        public void GetGeographyRepository(Action<GeographyRepository, Exception> callback)
        {
            var repo = new GeographyRepository();
            repo.CreateAll();
            callback(repo, null);
        }
    }
}