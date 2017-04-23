using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PatientDbContext : DbContext
    {
        public DbSet<Patients> Patients { get; set; }

        public PatientDbContext(DbContextOptions<PatientDbContext> options) : base(options)
        {

        }
    }
}
