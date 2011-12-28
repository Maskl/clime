using System;
using Clime.Model;

namespace Clime.MVVMUtils.DataServices
{
    class DesignDataService : IDataService
    {
        public void GetGeographyRepository(Action<GeographyRepository, Exception> callback)
        {
            var repo = new GeographyRepository();
            repo.CreateAllDesign();
            callback(repo, null);
        }
    }
}