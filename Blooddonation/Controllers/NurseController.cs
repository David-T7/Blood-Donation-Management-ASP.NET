using Blooddonation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Blooddonation.Controllers
{
    public class NurseController : Controller
    {

            private readonly BloodDonationDbContext _context;
            dynamic mymodel = new ExpandoObject();

          public NurseController(BloodDonationDbContext context)
            {
                _context = context;
            }
          

            public IActionResult dashbord()
            {
            mymodel.donationrequestlist = _context.DonationReqeustResult.ToList();
            mymodel.appointmentlist = _context.Appointment.ToList();
            mymodel.requestno = _context.DonationReqeustResult.Count();
            mymodel.acceptedrequest = _context.DonationReqeustResult.Where(r => r.Status == "accepted").Count();
            mymodel.rejectedrequest = _context.DonationReqeustResult.Where(r => r.Status == "rejected").Count();
            mymodel.inprogressrequest = _context.DonationReqeustResult.Where(r => r.Status == "inprogress").Count();
            return View(mymodel);
            }



             public IActionResult donationrequest()
            {
            mymodel.donationrequestlist = _context.DonationReqeustResult.ToList();
            mymodel.appointmentlist = _context.Appointment.ToList();
            return View(mymodel);
            }

            public IActionResult appointment()
         {
            var appointment = _context.Appointment.ToList();
            return View(appointment);
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

            Account account = _context.Account.Where(a => a.UserName == OldUserName).FirstOrDefault();
            if (account != null)
            {
                account.UserName = NewUsername;
                HttpContext.Session.SetString("username", NewUsername);
            }
            _context.SaveChanges();
            return Redirect("/nurse/editaccount");
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

            return Redirect("/nurse/editaccount");

        }

        [Route("nurse/donorinfo/{id}")]

        public IActionResult donorinfo(int id)
        {
            Donor donor = _context.Donor.Find(id);
            return View(donor);
        }

        [Route("nurse/requestresult/{id}")]

        public IActionResult requestresult(int id)
        {
            DonationReqeustResult res = _context.DonationReqeustResult.Find(id);
            return View(res);
        }


        [Route("nurse/requeststatus/{id}/{status}")]

        public IActionResult requeststatus(int id , string status)
        {
            DonationReqeustResult don = _context.DonationReqeustResult.Find(id);
            if(don != null)
            {
                don.Status = status;
            }
            _context.SaveChanges();

            return Redirect("/nurse/donationrequest");
        }


        [Route("nurse/appointmentstatus/{id}/{status}")]

        public IActionResult appointmentstatus(int id, string status)
        {
            Appointment app = _context.Appointment.Find(id);
            if (app != null)
            {
                app.Status = status;
            }
            _context.SaveChanges();

            return Redirect("/nurse/appointment");
        }







        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/home/login/nurse");
        }



    }
}
