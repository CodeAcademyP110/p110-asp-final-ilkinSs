using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TurboUlviFinalAsp.DAL;
using TurboUlviFinalAsp.Models;
using TurboUlviFinalAsp.ViewModels;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace TurboUlviFinalAsp.Controllers
{
    public class AccountController : Controller
    {
        private readonly DB_Context context;
        private readonly IConfiguration configuration;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;


        public AccountController(DB_Context _context, 
                                 UserManager<ApplicationUser> _userManager, 
                                  IConfiguration _configuration,
                                  SignInManager<ApplicationUser> _signInManager)
        {
            context = _context;
            userManager = _userManager;
            configuration = _configuration;
            signInManager = _signInManager;
        }



        public IActionResult Register()
        {
            return View();
        }



        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Duzgun Yazin Please");

                return View(registerViewModel);
            }

            ApplicationUser user = new ApplicationUser
            {
                Email = registerViewModel.Email,
                Firstname = registerViewModel.Firstname,
                Lastname = registerViewModel.Lastname,
                PhoneNumber = registerViewModel.PhoneNumber,
                RegistrationTime = DateTime.Now,
                UserName=registerViewModel.UserName
            };


            IdentityResult result = await userManager.CreateAsync(user, registerViewModel.Password);

            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);

                }
                return View(registerViewModel);
            }



            //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            //client.UseDefaultCredentials = false;
            //client.EnableSsl = true;
            //client.Credentials = new NetworkCredential(configuration["ConnectionsStrings:SmtpClientCredentialEmail"],
            //                                        configuration["ConnectionsStrings:SmtpClientCredentialPassword"]);
            //MailMessage message = new MailMessage("insinekuliziader@gmail.com", registerViewModel.Email);
            //message.IsBodyHtml = true;
            //message.Subject = "Hesabın təsdiqlənməsi";
            //message.Body = $"<a href='https://localhost:44363/Account/ConfirmationEmail?id={user.Id}'>Xahiw edirik Hesabınızi təsdiqləyəsiniz</a>";
            //client.Send(message);

            return RedirectToAction("Login", "Account");
        }



        public IActionResult Login()
        {
            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            ApplicationUser user = await userManager.FindByNameAsync(loginViewModel.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "Duzgun Yazin Please");
                return View(loginViewModel);
            }


            SignInResult signin = await signInManager.CheckPasswordSignInAsync(user, loginViewModel.Password, false);
            if (signin.Succeeded)
            {
                await signInManager.SignInAsync(user,false);
            }else
            {
                ModelState.AddModelError("", "Duzgun Yazin Please");
                return View();
            }



            return RedirectToAction("Index", "Home");
        }
    }
}