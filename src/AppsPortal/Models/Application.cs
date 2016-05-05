using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string PromotionVideoUrl { get; set; }        

        public ICollection<Release> Releases { get; set; }
    }
}
