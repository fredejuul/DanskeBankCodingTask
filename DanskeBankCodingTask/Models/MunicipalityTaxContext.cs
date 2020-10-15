using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DanskeBankCodingTask.Models
{
    public class MunicipalityTaxContext : DbContext
    {
        public MunicipalityTaxContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<MunicipalityTax> MunicipalityTaxes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MunicipalityTax>().HasData(new MunicipalityTax
            {
                ID = 1,
                Municipality = "Copenhagen",
                TaxRate = 0.2,
                Schedule = Schedule.Yearly,
                StartDate = new DateTime(2016, 01, 01),
                EndDate = new DateTime(2016, 12, 31)

            }, new MunicipalityTax
            {
                ID = 2,
                Municipality = "Copenhagen",
                TaxRate = 0.4,
                Schedule = Schedule.Monthly,
                StartDate = new DateTime(2016, 05, 01),
                EndDate = new DateTime(2016, 05, 31)
            }, new MunicipalityTax
            {
                ID = 3,
                Municipality = "Copenhagen",
                TaxRate = 0.1,
                Schedule = Schedule.Daily,
                StartDate = new DateTime(2016, 01, 01),
                EndDate = new DateTime(2016, 01, 01)
            }, new MunicipalityTax
            {
                ID = 4,
                Municipality = "Copenhagen",
                TaxRate = 0.1,
                Schedule = Schedule.Daily,
                StartDate = new DateTime(2016, 12, 25),
                EndDate = new DateTime(2016, 12, 25)
            });
        }
    }
}
