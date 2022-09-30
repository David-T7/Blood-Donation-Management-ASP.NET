using Blooddonation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Dynamic;
using System.Linq;

namespace Blooddonation.Controllers
{
    public class AdminController : Controller
    {

            private readonly BloodDonationDbContext _context;
            dynamic mymodel = new ExpandoObject();

        public AdminController(BloodDonationDbContext context)
            {
                _context = context;
            }


            public IActionResult dashbord()
            {
            mymodel.donorno = _context.Donor.Count();
            mymodel.nurseno = _context.Account.Where(a => a.Role == "nurse").Count();
            mymodel.labtechno = _context.Account.Where(a => a.Role == "labtechnician").Count();

            return View(mymodel);
            }


            public IActionResult accounts()
            {
            mymodel.donor = _context.Donor.ToList();
            mymodel.nurse = _context.Account.Where(a => a.Role == "nurse");
            mymodel.labtechnician = _context.Account.Where(a => a.Role == "labtechnician");
            return View(mymodel);
            }
            
            public IActionResult createaccount()
              {
            return View();
              }

            [HttpPost]
            public IActionResult createaccount(Account account)
            {
            _context.Account.Add(account);
            _context.SaveChanges();
            return Redirect("/Admin/accounts");
            
            }


        [Route("admin/edituseraccount/{id}")]
        public IActionResult edituseraccount(int id )
            {
            var account = _context.Account.Find(id);
            return View(account);
            
            }


        [HttpPost]
        public IActionResult edituseraccounts(string OldUsername, string NewUsername)
        {
            Account account = _context.Account.Where(a => a.UserName == OldUsername).FirstOrDefault();
            if(account != null)
            {
                account.UserName = NewUsername;
            }
            _context.SaveChanges();
            return Redirect("/admin/accounts");

        }


        public IActionResult changeuserpassword()
        {
            return View();

        }

        [HttpPost]
        [Route("admin/changeuserpassword/{id}")]

        public IActionResult changeuserpassword(int id , string NewPassword)
        {
            var account = _context.Account.Find(id);
  
            if (account != null)
            {
                account.Password = NewPassword;
            }
            _context.SaveChanges();
            return Redirect("/admin/accounts");

        }


        [Route("admin/deleteuseraccount/{id}")]

        public IActionResult deleteuseraccount(int id)
        {
            var account = _context.Account.Find(id);
            if(account.Role == "donor")
            {
                Donor donor = _context.Donor.Where(d => account.AccountId == account.AccountId).FirstOrDefault();
                _context.Donor.Remove(donor);
            }
            _context.Account.Remove(account);
            _context.SaveChanges();
            return Redirect("/admin/accounts");

        }



        public IActionResult editaccount()
        {
            string username = HttpContext.Session.GetString("username");
            ViewBag.username = username;
            return View();

        }
        [HttpPost]
        public IActionResult editaccount(string OldUserName, string NewUsername)
        {

            Account account = _context.Account.Where(a => a.UserName == OldUserName && a.Role == "admin").FirstOrDefault();
            if (account != null)
            {
                account.UserName = NewUsername;
                HttpContext.Session.SetString("username", NewUsername);
            }
            _context.SaveChanges();
            return Redirect("/admin/editaccount");
        }


        public IActionResult changepassword()
        {
            return View();

        }

        [HttpPost]
        public IActionResult changepassword(string OldPassword, string NewPassword)
        {
            Account account = _context.Account.Where(a => a.Password == OldPassword).FirstOrDefault();
            if (account != null)
            {
                account.Password = NewPassword;
                HttpContext.Session.SetString("password", NewPassword);

            }

            _context.SaveChanges();

            return Redirect("/admin/editaccount");

        }



        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/home/login/admin");
        }














    }
}
