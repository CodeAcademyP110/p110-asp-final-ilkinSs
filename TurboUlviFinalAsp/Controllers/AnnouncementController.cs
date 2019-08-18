using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TurboUlviFinalAsp.DAL;
using TurboUlviFinalAsp.Extensions;
using TurboUlviFinalAsp.Models;


namespace TurboUlviFinalAsp.Controllers
{
    public class AnnouncementController : Controller
    {

        private readonly DB_Context context;
        private readonly IConfiguration configuration;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHostingEnvironment env;



        public AnnouncementController(DB_Context _context,
                                 UserManager<ApplicationUser> _userManager,
                                  IConfiguration _configuration,
                                   IHostingEnvironment _env
                               )
        {
            context = _context;
            userManager = _userManager;
            configuration = _configuration;
            env = _env;

        }

        public IActionResult Create()
        {
            ViewBag.Marcas = context.Marcas;
            ViewBag.Models = context.Models;
            ViewBag.Cities = context.Cities;
            ViewBag.CarBodies = context.CarBodies;
            ViewBag.GraduationYears = context.GraduationYears;
            ViewBag.Motors = context.Motors;
            ViewBag.GearBoxes = context.GearBoxes;
            ViewBag.Transmissions = context.Transmissions;
            ViewBag.Colors = context.Colors;
            ViewBag.Fuels = context.Fuels;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Announcement announcement)
        {

            ApplicationUser user = await userManager.FindByNameAsync(User.Identity.Name);
            announcement.ApplicationUserId = user.Id;

            ViewBag.Marcas = context.Marcas;
            ViewBag.Models = context.Models;
            ViewBag.Cities = context.Cities;
            ViewBag.CarBodies = context.CarBodies;
            ViewBag.GraduationYears = context.GraduationYears;
            ViewBag.Motors = context.Motors;
            ViewBag.GearBoxes = context.GearBoxes;
            ViewBag.Transmissions = context.Transmissions;
            ViewBag.Colors = context.Colors;
            ViewBag.Fuels = context.Fuels;

            if (!ModelState.IsValid)
            {
                ViewBag.Marcas = context.Marcas;
                ViewBag.Models = context.Models;
                ViewBag.Cities = context.Cities;
                ViewBag.CarBodies = context.CarBodies;
                ViewBag.GraduationYears = context.GraduationYears;
                ViewBag.Motors = context.Motors;
                ViewBag.GearBoxes = context.GearBoxes;
                ViewBag.Transmissions = context.Transmissions;
                ViewBag.Colors = context.Colors;
                ViewBag.Fuels = context.Fuels;
                ModelState.AddModelError("", "Please input valid properties");
                return View(announcement);
            }

            if (announcement.Photos == null)
            {
                ViewBag.Marcas = context.Marcas;
                ViewBag.Models = context.Models;
                ViewBag.Cities = context.Cities;
                ViewBag.CarBodies = context.CarBodies;
                ViewBag.GraduationYears = context.GraduationYears;
                ViewBag.Motors = context.Motors;
                ViewBag.GearBoxes = context.GearBoxes;
                ViewBag.Transmissions = context.Transmissions;
                ViewBag.Colors = context.Colors;
                ViewBag.Fuels = context.Fuels;
                ModelState.AddModelError("Image", "Please input Image");
                return View(announcement);
            }

            foreach (var item in announcement.AllPhotos)
            {
                if (item == null)
                {
                    ViewBag.Marcas = context.Marcas;
                    ViewBag.Models = context.Models;
                    ViewBag.Cities = context.Cities;
                    ViewBag.CarBodies = context.CarBodies;
                    ViewBag.GraduationYears = context.GraduationYears;
                    ViewBag.Motors = context.Motors;
                    ViewBag.GearBoxes = context.GearBoxes;
                    ViewBag.Transmissions = context.Transmissions;
                    ViewBag.Colors = context.Colors;
                    ViewBag.Fuels = context.Fuels;
                    ModelState.AddModelError("Image", "Please input Image");
                    return View(announcement);
                }
            }

            Announcement announ = new Announcement()
            {
                Distance = announcement.Distance,
                Price = announcement.Price,
                FullInfo = announcement.FullInfo,
                ShortInfo = announcement.ShortInfo,
                PublishDate = DateTime.Now,
                CityId = announcement.CityId,
                CarBodyId = announcement.CarBodyId,
                ColorId = announcement.ColorId,
                FuelId = announcement.FuelId,
                GraduationYearId = announcement.GraduationYearId,
                ModelId = announcement.ModelId,
                GearBoxId = announcement.GearBoxId,
                TransmissionId = announcement.TransmissionId,
                ApplicationUserId = announcement.ApplicationUserId,
                IsVip = announcement.IsVip,
                MotorId = announcement.MotorId,
            };

            if (announcement.Photos.ContentType.Contains("image/"))
            {

               // IFormFileExtensions()
                string folderPath = Path.Combine(env.WebRootPath, "image");
                string fileName = Guid.NewGuid().ToString() + "_" + announcement.Photos.FileName;
                string filePath = Path.Combine(folderPath, fileName);
                announ.PhotoUrl = fileName;

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await announcement.Photos.CopyToAsync(fileStream);
                }
            }

            await context.Announcements.AddAsync(announ);

            foreach (var Pho in announcement.AllPhotos)
            {
                if (Pho.ContentType.Contains("image/"))
                {
                    string folderPathAll = Path.Combine(env.WebRootPath, "image");
                    string fileNameAll = Guid.NewGuid().ToString() + "_" + announcement.Photos.FileName;
                    string filePathAll = Path.Combine(folderPathAll, fileNameAll);

                    using (FileStream fileStream = new FileStream(filePathAll, FileMode.Create))
                    {
                        await announcement.AllPhotos.FirstOrDefault().CopyToAsync(fileStream);
                    }

                    Image img = new Image()
                    {
                        AnnouncementId = announ.Id,
                        Name = fileNameAll
                    };

                    await context.Images.AddAsync(img);
                }
            }

            await context.SaveChangesAsync();
            return RedirectToAction("Details", "Home");
        }

        private void IFormFileExtensions()
        {
            throw new NotImplementedException();
        }

        //[HttpPost, ValidateAntiForgeryToken]
        //public IActionResult Index( Announcement announcementModel)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "Duzgun Yazin Please");

        //        return View();
        //    }

        //    Announcement announcement = new Announcement {

        //    }

        //}

    }
}