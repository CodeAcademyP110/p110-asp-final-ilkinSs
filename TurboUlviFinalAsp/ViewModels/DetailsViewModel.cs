using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboUlviFinalAsp.Models;

namespace TurboUlviFinalAsp.ViewModels
{
    public class DetailsViewModel { 
    
        public IEnumerable<Announcement> Announcements { get; set; }
        public Announcement Announcement { get; set; }

        public Image Image { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
