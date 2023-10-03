using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidHealthDeclarationForm.Models;

namespace CovidHealthDeclarationForm.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<CovidHealthDeclarationForm.Models.HealthDeclarationData> HealthDeclarationData { get; set; }
        public DbSet<CovidHealthDeclarationForm.Models.SensorData> SensorData { get; set; }
        public DbSet<CovidHealthDeclarationForm.Models.ActivityLog> ActivityLog { get; set; }
    }
}
