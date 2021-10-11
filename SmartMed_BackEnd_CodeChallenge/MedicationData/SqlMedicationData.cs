using SmartMed_BackEnd_CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed_BackEnd_CodeChallenge.MedicationData
{
    public class SqlMedicationData : IMedicationData
    {
        private MedicationContext _medicationContext;
        public SqlMedicationData(MedicationContext medicationContext)
        {
            _medicationContext = medicationContext;
        }

        public Medication AddMedication(Medication medication)
        {
            medication.Id = Guid.NewGuid();
            medication.CreationDate = DateTime.Now;
            _medicationContext.Medications.Add(medication);
            _medicationContext.SaveChanges();
            return medication;
        }

        public void DeleteMedication(Medication medication)
        {
            _medicationContext.Medications.Remove(medication);
            _medicationContext.SaveChanges();
        }

        public Medication GetMedication(Guid id)
        {
            var medication = _medicationContext.Medications.Find(id);
            return medication;
        }

        public List<Medication> GetMedications()
        {
            return _medicationContext.Medications.ToList();
        }
    }
}
