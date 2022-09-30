using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blooddonation.Models
{
    public class Blood
    {
        [Key] 
        public int BloodId { get; set; }
        public int DonorId {get;set; }

        public string BloodType { get; set; }

        public int PackNumber { get; set;  }

        public DateTime RegDate { get; set; }

        public DateTime ExpDate { get; set; }

        public float QuantityOfBlood { get; set;  }

        public virtual Donor Donor { get; set; }


    }



}
