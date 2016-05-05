using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Models
{
    public class AppsContextSeedData
    {
        private AppsContext _context;

        public AppsContextSeedData(AppsContext context)
        {
            _context = context;
        }

        public void EnsureSeedData()
        {
            if(!_context.Applications.Any())
            {
                /// Add new application data

                var modelLauncherApp = new Application()
                {
                    Name = "Model Launcher",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    PromotionVideoUrl = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    Releases = new List<Release>()
                    {
                        new Release() { Details = "Initial Release", Date = new DateTime(2015, 7, 1), AppVersion = "1.3.1", Order = 1  },
                        new Release() { Details = "Bug Fixes 1", Date = new DateTime(2015, 7, 15), AppVersion = "1.3.2", Order = 2  },
                        new Release() { Details = "Bug Fixes 2", Date = new DateTime(2015, 8, 15), AppVersion = "1.3.3", Order = 3  },
                        new Release() { Details = "Bug Fixes 3", Date = new DateTime(2015, 9, 15), AppVersion = "1.3.4", Order = 4  },
                        new Release() { Details = "Bug Fixes 4", Date = new DateTime(2015, 10, 15), AppVersion = "1.3.5", Order = 5  },
                        new Release() { Details = "Bug Fixes 4", Date = new DateTime(2015, 10, 15), AppVersion = "1.3.6", Order = 6  }                        
                    }
                    
                };

                _context.Applications.Add(modelLauncherApp);
                _context.Releases.AddRange(modelLauncherApp.Releases);

                var packageToolApp = new Application()
                {
                    Name = "Package Tool",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    PromotionVideoUrl = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    Releases = new List<Release>()
                    {
                        new Release() { Details = "Initial Release", Date = new DateTime(2015, 8, 1), AppVersion = "1.0.4", Order = 1  },
                        new Release() { Details = "Bug Fixes 1", Date = new DateTime(2015, 9, 15), AppVersion = "1.0.5", Order = 2  }
                    }

                };

                _context.Applications.Add(packageToolApp);
                _context.Releases.AddRange(packageToolApp.Releases);

                var appsPortal = new Application()
                {
                    Name = "AppsPortal",
                    Description = "Nulla sodales aliquet iaculis. Quisque ullamcorper posuere magna non imperdiet. Fusce egestas arcu sit amet orci volutpat venenatis. Proin laoreet leo quis nulla iaculis id tincidunt arcu laoreet. Cras non ante felis, at pulvinar arcu. Vivamus porta sollicitudin massa congue elementum. Proin fringilla massa vel mi ultricies et molestie justo dapibus. Mauris elit orci, euismod non sodales ac, gravida eget mauris.",
                    PromotionVideoUrl = "http://www.youtube.com/embed/fxCEcPxUbYA",
                    Releases = new List<Release>()
                    {
                        new Release() { Details = "Initial Release", Date = new DateTime(2015, 8, 1), AppVersion = "1.0.0", Order = 1  },
                        new Release() { Details = "Bug Fixes 1", Date = new DateTime(2015, 9, 15), AppVersion = "1.0.1", Order = 2  },
                        new Release() { Details = "Bug Fixes 2", Date = new DateTime(2015, 10, 15), AppVersion = "1.0.2", Order = 3  },
                        new Release() { Details = "Bug Fixes 3", Date = new DateTime(2015, 11, 15), AppVersion = "1.0.3", Order = 4  },
                        new Release() { Details = "Bug Fixes 4", Date = new DateTime(2015, 12, 15), AppVersion = "1.0.4", Order = 5  }
                    }

                };

                _context.Applications.Add(appsPortal);
                _context.Releases.AddRange(appsPortal.Releases);

                // Push changes to the database
                _context.SaveChanges();
            }
        }

    }
}
