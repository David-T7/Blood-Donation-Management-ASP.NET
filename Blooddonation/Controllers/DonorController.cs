using Blooddonation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace Blooddonation.Controllers
{
    public class DonorController : Controller
    {

            private readonly BloodDonationDbContext _context;
            dynamic mymodel = new ExpandoObject();

        public DonorController(BloodDonationDbContext context)
            {
                _context = context;
            }
          

            public IActionResult Index()
            {
                 return View();
            }


        public IActionResult dashbord()
        {
            Int32 accountid = Int32.Parse( HttpContext.Session.GetInt32("accountid").ToString());


            Donor donor = _context.Donor.Where(d => d.AccountId.Equals(accountid)).FirstOrDefault();

            mymodel.donationrequest = _context.DonationReqeustResult.Where(d => d.DonorId.Equals(donor.DonorId)).ToList();
            mymodel.appointmentlist = _context.Appointment.Where(d => d.DonorId.Equals(donor.DonorId)).ToList();


            return View(mymodel);
           
            }

            public IActionResult appointmentlist()
            {
            Int32 accountid = Int32.Parse(HttpContext.Session.GetInt32("accountid").ToString());
            Donor donor = _context.Donor.Where(d => d.AccountId.Equals(accountid)).FirstOrDefault();
            var appointmentlist = _context.Appointment.Where(a => a.DonorId.Equals(donor.DonorId)).ToList();

            return View(appointmentlist);
            }



            public IActionResult donationrequestlist()
            {
            Int32 accountid = Int32.Parse( HttpContext.Session.GetInt32("accountid").ToString());
            Donor donor = _context.Donor.Where(d => d.AccountId.Equals(accountid)).FirstOrDefault();

            mymodel.donationrequest = _context.DonationReqeustResult.Where(d => d.DonorId.Equals(donor.DonorId)).ToList();
            mymodel.appointmentlist = _context.Appointment.Where(d => d.DonorId.Equals(donor.DonorId)).ToList();
        
            return View(mymodel);
            }

            public IActionResult makeappointment()
            {                   
            return View();
            }


            
            [HttpPost]
            [Route("donor/makeappointment/{id}/")]

            public IActionResult makeappointment(int id , DateTime AppointmentDate)
             {
            Int32 accountid = Int32.Parse(HttpContext.Session.GetInt32("accountid").ToString());
            Donor donor = _context.Donor.Where(d => d.AccountId.Equals(accountid)).FirstOrDefault();
            Appointment appointment = new Appointment();
            appointment.AppointmentDate = AppointmentDate;
            appointment.DonorId = donor.DonorId;
            appointment.Status = "inprogress";
            appointment.ReqeustResultId = id;
            _context.Appointment.Add(appointment);
            _context.SaveChanges();
            return Redirect("/donor/appointmentlist");
            }


        [Route("donor/cancelappointment/{id}/")]

        public IActionResult cancelappointment(int id)
        {
            Appointment appointment =  _context.Appointment.Find(id);
            _context.Appointment.Remove(appointment);
            _context.SaveChanges();
            return Redirect("/donor/appointmentlist");

        }



        [Route("donor/cancelrequest/{id}/")]

        public IActionResult cancelrequest(int id)
        {
            DonationReqeustResult request = _context.DonationReqeustResult.Find(id);
            _context.DonationReqeustResult.Remove(request);
            _context.SaveChanges();
            return Redirect("/donor/donationrequestlist");

        }





        public IActionResult register()
             {
             return View();
             }
            [HttpPost]
            public IActionResult register (Donor donor ,  Account account)
            {
            _context.Account.Add(account);
            account.Role = "donor";
            _context.SaveChanges();
            donor.AccountId = account.AccountId;
            _context.Donor.Add(donor);
            _context.SaveChanges();
            return Redirect("/home/login/donor");
            }

            public IActionResult createdonationrequest()
             {
            return View();
             }

            [HttpPost]
            public IActionResult createdonationrequest(DonationReqeustResult requestresult)
            {
            Int32 accountid = Int32.Parse( HttpContext.Session.GetInt32("accountid").ToString());
            Donor donor = _context.Donor.Where(d => d.AccountId.Equals(accountid)).FirstOrDefault();
            _context.DonationReqeustResult.Add(requestresult);
            requestresult.DonorId = donor.DonorId;
            requestresult.Status = "inprogress";
            requestresult.RequestDate = DateTime.Now;
            _context.SaveChanges();
            return Redirect("/donor/donationrequestlist");
            }

              public IActionResult editaccount()
            {
            string username = HttpContext.Session.GetString("username");
            ViewBag.username = username;
            return View();

        }
            [HttpPost]
              public IActionResult editaccount(string  OldUserName , string NewUsername)
           {

            Account account = _context.Account.Where(a => a.UserName == OldUserName).FirstOrDefault();
            if (account != null)
            {
                account.UserName = NewUsername;
                HttpContext.Session.SetString("username" ,  NewUsername);
            }
            _context.SaveChanges();
            return Redirect("/donor/editaccount");
           }
        public IActionResult changepassword()
        {
            return View();

        }

        [HttpPost]
        public IActionResult changepassword(string OldPassword , string NewPassword )
        {
            Account account = _context.Account.Where(a => a.Password == OldPassword).FirstOrDefault();
            if(account != null)
            {
                account.Password = NewPassword;
                HttpContext.Session.SetString("password", NewPassword);

            }

            _context.SaveChanges();

            return Redirect("/donor/editaccount");

        }




        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/home/login/donor");
        }














    }
}
