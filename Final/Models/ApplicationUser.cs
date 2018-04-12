using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace Final.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
    }
}
