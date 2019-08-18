using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TurboUlviFinalAsp.DAL;
using TurboUlviFinalAsp.Models;

namespace TurboUlviFinalAsp.Controllers
{
    public class AjaxController : Controller
    {

        private readonly DB_Context context;
        private readonly IConfiguration configuration;
        private readonly UserManager<ApplicationUser> userManager;



        public AjaxController(DB_Context _context,
                                 UserManager<ApplicationUser> _userManager,
                                  IConfiguration _configuration
                               )
        {
            context = _context;
            userManager = _userManager;
            configuration = _configuration;

        }
        public IActionResult Index(int? id)
        {
            return PartialView("Index", context.Models.Where(x => x.MarcaId == id));
        }
    }
}