using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Models
{
    public class AppsRepository : IAppsRepository
    {
        private AppsContext _context;

        public AppsRepository(AppsContext context)
        {
            _context = context;
        }

        public IEnumerable<Application> GetAllApplication()
        {
            return _context.Applications
                .OrderBy(a => a.Id)
                .ToList();
          
        }

        public IEnumerable<Application> GetAllVersionsByApplication()
        {
            return _context.Applications
                .Include(a => a.Releases)
                .OrderBy(a => a.Id)
                .ToList();
        }
    }
}
