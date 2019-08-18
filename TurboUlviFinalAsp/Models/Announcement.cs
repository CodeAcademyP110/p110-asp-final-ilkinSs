using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TurboUlviFinalAsp.Models
{
    public class Announcement
    {
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Distance { get; set; }
       

        [Required, StringLength(500)]
        public string ShortInfo { get; set; }

        public string FullInfo { get; set; }
        public DateTime PublishDate { get; set; }
        public int CarBodyId { get; set; }
        public virtual CarBody CarBody { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public int FuelId { get; set; }
        public virtual Fuel Fuel { get; set; }
        public int GearBoxId { get; set; }
        public virtual GearBox GearBox { get; set; }
        public int GraduationYearId { get; set; }
        public virtual GraduationYear GraduationYear { get; set; }
 
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public int MotorId { get; set; }
        public virtual Motor Motor { get; set; }
        public int TransmissionId { get; set; }
        public virtual Transmission Transmission { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public bool IsVip { get; set; }



        public string PhotoUrl { get; set; }

        [NotMapped]
        public IFormFile Photos { get; set; }

        public virtual ICollection<Image> Images { get; set; }


        [NotMapped]
        public ICollection<IFormFile> AllPhotos { get; set; }
    }
}
