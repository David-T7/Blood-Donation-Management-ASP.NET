using Blooddonation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





namespace Blooddonation.Controllers
{
    public class HomeController : Controller
    {

            private readonly BloodDonationDbContext _context;
            public HomeController(BloodDonationDbContext context)
            {
                _context = context;
            }


        public IActionResult Index()
            {
                 return View();
            }

        public IActionResult aboutus()
        {
            return View();
        }
            [Route("home/login/{role}")]

           public IActionResult Login(string  role)
            {
                ViewData["role"] = role;
                return View();
            }

        [Route("home/login/{role}")]
        [HttpPost]
        public IActionResult Login(string role, Account account)
        {     
             var obj = _context.Account.Where(a => a.UserName.Equals(account.UserName) && a.Password.Equals(account.Password) && a.Role.Equals(role)).FirstOrDefault();
            
          
            if (obj != null)
            {
                
                HttpContext.Session.SetString("username", obj.UserName);
                HttpContext.Session.SetString("password", obj.Password);
                HttpContext.Session.SetInt32("accountid", obj.AccountId);



                if (role == "donor")
                {
                    
                    return RedirectToAction("dashbord", "Donor");

                }
                else if (role == "labtechnician")
                    {
                    return RedirectToAction("dashbord", "LabTechnician");
                }
                else if (role == "nurse")
                    {
                    return RedirectToAction("dashbord", "Nurse");
                }
                else if (role == "admin")
                {
                    return RedirectToAction("dashbord", "admin");
                }
            }
            ViewData["role"] = role;
            ViewData["error"] = "username or password incorrect";
            return View();
        }




    }
}
