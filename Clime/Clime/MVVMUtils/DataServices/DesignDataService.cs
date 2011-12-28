using System;
using Clime.Model;

namespace Clime.MVVMUtils.DataServices
{
    public class DesignDataService : IDataService
    {
        public void GetGeographyRepository(Action<GeographyRepository, Exception> callback)
        {
            var repo = new GeographyRepository();
            repo.CreateAllDesign();
            callback(repo, null);
        }
    }
}