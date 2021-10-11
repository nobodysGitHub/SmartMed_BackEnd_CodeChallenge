using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed_BackEnd_CodeChallenge.Models
{
    public class MedicationContext: DbContext
    {
        public MedicationContext(DbContextOptions<MedicationContext> options): base(options)
        {

        }

        public DbSet<Medication> Medications { get; set; }
    }
}
