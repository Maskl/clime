using System;
using Clime.Model;

namespace Clime.MVVMUtils.DataServices
{
    public class DataService : IDataService
    {
        public void GetGeographyRepository(Action<GeographyRepository, Exception> callback)
        {
            var repo = new GeographyRepository();
            repo.CreateAll();
            callback(repo, null);
        }
    }
}