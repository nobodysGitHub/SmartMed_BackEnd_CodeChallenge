using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed_BackEnd_CodeChallenge.Models
{
    public class Medication
    {
        [Key]
        public Guid Id { get; set; }

        //[Required]
        public string Name { get; set; }

        //[Required]
        public int Quantity { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
