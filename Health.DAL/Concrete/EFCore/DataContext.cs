using Health.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.DAL.Concrete.EFCore
{
    public class DataContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D68FUN4; Database=Health; Integrated Security=true; TrustServerCertificate=True;");
        }
       
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MailBox> MailBoxs { get; set; }
        public DbSet<Branch> Branchs { get; set; }
    }
}