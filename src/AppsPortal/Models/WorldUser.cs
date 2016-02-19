using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace AppsPortal.Models
{
    public class WorldUser : IdentityUser
    {
        public DateTime FirstTrip { get; set; }
    }
}