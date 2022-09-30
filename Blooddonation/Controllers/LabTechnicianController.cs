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
    public class LabTechnicianController : Controller
    {

            private readonly BloodDonationDbContext _context;
            dynamic mymodel = new ExpandoObject();

        public LabTechnicianController(BloodDonationDbContext context)
            {
                _context = context;
            }
          

           
            public IActionResult dashbord()
            {
            mymodel.op = _context.Blood.Where(b => b.BloodType == "O+").Count();
            mymodel.on = _context.Blood.Where(b => b.BloodType == "O-").Count();
            mymodel.ap = _context.Blood.Where(b => b.BloodType == "A+").Count();
            mymodel.an = _context.Blood.Where(b => b.BloodType == "A-").Count();
            mymodel.bp = _context.Blood.Where(b => b.BloodType == "B+").Count();
            mymodel.bn = _context.Blood.Where(b => b.BloodType == "B-").Count();
            mymodel.abp = _context.Blood.Where(b => b.BloodType == "AB+").Count();
            mymodel.abn = _context.Blood.Where(b => b.BloodType == "AB-").Count();

            return View(mymodel);
            }

        public IActionResult bloods()
        {
            var blood = _context.Blood.ToList();
            return View(blood);
        }

        [Route("labtechnician/blockdonor/{id}")]

        public IActionResult blockdonor(int id )
        {
            BlockedDonor blockeddonor = new BlockedDonor();
            blockeddonor.DonorId = id;
            _context.BlockedDonor.Add(blockeddonor);
            _context.SaveChanges();
            return Redirect("/labtechnician/requestresult");
        }


        [Route("labtechnician/donorinfo/{id}")]

        public IActionResult donorinfo(int id)
        {
            Donor donor = _context.Donor.Find(id);
            return View(donor);
        }


        public IActionResult donationrequest()
        {
            mymodel.donationrequestlist = _context.DonationReqeustResult.ToList();
            mymodel.appointmentlist = _context.Appointment.ToList();
            return View(mymodel);
        }
        [Route("labtechnician/addblood/{donorid}/{requestid}")]

        public IActionResult addblood( int donorid , int requestid)
        {
           mymodel.donor = _context.Donor.Find(donorid);
           mymodel.request = _context.DonationReqeustResult.Find(requestid);
            
            return View(mymodel);
        }


        public IActionResult updateblood(int id)
        {
            Blood blood = _context.Blood.Find(id);
            return View(blood);

        }
        
        [HttpPost]
        public IActionResult updateblood(Blood blood )
        {
            
            _context.Blood.Update(blood);
            _context.SaveChanges();
            return Redirect("/labtechnician/bloods");

        }


        public IActionResult deleteblood(int id)
        {
            Blood blood = _context.Blood.Find(id);
            _context.Blood.Remove(blood);
            _context.SaveChanges();
            return Redirect("/labtechnician/bloods");
        }









        [HttpPost]
        [Route("labtechnician/addblood/{donorid}/{requestid}")]
        public IActionResult addblood(Blood blood , int donorid , int requestid)
        {
            _context.Blood.Add(blood);
            blood.DonorId = donorid;
            DonationReqeustResult request = _context.DonationReqeustResult.Find(requestid);
            request.Status = "finished";
            _context.SaveChanges();
            return Redirect("/labtechnician/bloods");
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
            return Redirect("/labtechnician/editaccount");
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

            return Redirect("/labtechnician/editaccount");

        }





        public IActionResult logout()
             {
               HttpContext.Session.Clear();
               return Redirect("/home/login/labtechnician");
             }







    }
}
