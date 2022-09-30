using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blooddonation.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string UserName { get; set; }
        
        public string Password { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

    }
}
