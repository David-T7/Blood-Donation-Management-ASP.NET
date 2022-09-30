using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blooddonation.Models
{
    public class Donor
    {
        [Key]
        public int DonorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int AccountId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string BloodType { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public string Gender { get; set; }
        public long PhoneNo { get; set; }

        public float BMI { get; set; }
        public virtual Account Account { get; set; }



    }


    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public int DonorId { get; set; }
        public int ReqeustResultId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; }
        public virtual Donor Donor { get; set; }
        public virtual DonationReqeustResult DonationReqeustResult { get; set; }



    }




    public class DonationReqeustResult
    {
        [Key]

        public int ReqeustResultId { get; set; }

        public int DonorId { get; set; }

        public string HeartDisease { get; set; }


        public string Kidney_Lung_Bloodpressure { get; set; }

        public string Liverproblems { get; set; }

        public string STD { get; set; }
        public string Tattoo_Ear_skin_pierced { get; set; }


        public string Slpet_Unsafely_OtherThanPartner { get; set; }

        public string SeriousSkinRepair { get; set; }

        public string Preagnant { get; set; }


        public string Abortion { get; set; }


        public string BreastFeeding { get; set; }


        public string BloodHealthfulnessInfo { get; set; }

        public string Status { get; set; }

        public DateTime RequestDate { get; set; }

        public virtual Donor Donor { get; set; }



    }



    public class BlockedDonor
    {
        [Key]
        public int id { get; set; }   
        public int DonorId { get; set; }
        public virtual Donor Donor { get; set; }



    }
}
