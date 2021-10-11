using SmartMed_BackEnd_CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed_BackEnd_CodeChallenge.MedicationData
{
    public class MockMedicationData : IMedicationData
    {
        private List<Medication> medications = new List<Medication>()
        {
            new Medication()
            {
                Id = Guid.NewGuid(),
                Name = "Pennicillina",
                Quantity = 2,
                CreationDate = DateTime.Today
            },
            new Medication()
            {
                Id = Guid.NewGuid(),
                Name = "Tachipirina",
                Quantity = 3,
                CreationDate = DateTime.Today
            }
        };



        

       

        public List<Medication> GetMedications()
        {
            return medications;
        }

        public Medication GetMedication(Guid id)
        {
            return medications.SingleOrDefault(x => x.Id == id);
        }

        public Medication AddMedication(Medication medication)
        {
            medication.Id = Guid.NewGuid();
            medication.CreationDate = DateTime.Now;
            medications.Add(medication);
            return medication;
        }

        public void DeleteMedication(Medication medication)
        {
            medications.Remove(medication);
        }

    }
}
