using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.ViewModels
{
    public class DownloadViewModel
    {

        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string Company { get; set; }
    }
}
