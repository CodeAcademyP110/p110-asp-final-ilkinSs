using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TurboUlviFinalAsp.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AnnouncementId { get; set; }

        [NotMapped]
        public virtual  ICollection<Announcement> Announcement { get; set; }
    }
}
