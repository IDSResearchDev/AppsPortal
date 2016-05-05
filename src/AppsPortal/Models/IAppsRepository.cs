using System.Collections.Generic;

namespace AppsPortal.Models
{
    public interface IAppsRepository
    {
        IEnumerable<Application> GetAllApplication();
        IEnumerable<Application> GetAllVersionsByApplication();
    }
}