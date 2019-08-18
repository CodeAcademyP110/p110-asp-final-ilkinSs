using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TurboUlviFinalAsp.DAL;
using TurboUlviFinalAsp.Models;
using TurboUlviFinalAsp.ViewModels;

namespace TurboUlviFinalAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DB_Context context;

        public HomeController(DB_Context _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult News()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Details(int? id)
        {
            DetailsViewModel model = new DetailsViewModel()
            {
                Announcement = context.Announcements.FirstOrDefault(anno => anno.Id == id),
                Announcements = context.Announcements.Where(anno => anno.ModelId == context.Announcements.FirstOrDefault(announ => announ.Id == id).ModelId)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Details()
        {
            return View();
        }

        
  



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
