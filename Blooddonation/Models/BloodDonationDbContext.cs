using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blooddonation.Models
{
    public class BloodDonationDbContext:DbContext
    {

        public BloodDonationDbContext(DbContextOptions <BloodDonationDbContext> options ): base(options)
        {
                
        }


        public DbSet<Donor> Donor { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Blood> Blood { get; set; }
        public DbSet<DonationReqeustResult> DonationReqeustResult { get; set; }

        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<BlockedDonor> BlockedDonor { get; set; }










    }
}
