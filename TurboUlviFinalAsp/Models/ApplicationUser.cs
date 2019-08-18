using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurboUlviFinalAsp.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        [Required, StringLength(100)]
        public string Firstname { get; set; }

        public string Lastname { get; set; }


        public DateTime RegistrationTime { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }



    }
}
