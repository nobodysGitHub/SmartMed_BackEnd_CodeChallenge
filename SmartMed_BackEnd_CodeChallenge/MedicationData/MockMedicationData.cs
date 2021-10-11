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



        public Medication AddMedication(Medication medication)
        {
            throw new NotImplementedException();
        }

        public void DeleteMedication(Medication medication)
        {
            throw new NotImplementedException();
        }

        public Medication GetMedication(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Medication> GetMedications()
        {
            return medications;
        }
    }
}
