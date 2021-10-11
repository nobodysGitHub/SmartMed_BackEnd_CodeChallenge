using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed_BackEnd_CodeChallenge.Models
{
    public class Medication
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
