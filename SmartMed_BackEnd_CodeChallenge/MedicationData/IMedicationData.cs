using SmartMed_BackEnd_CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed_BackEnd_CodeChallenge.MedicationData
{
    public interface IMedicationData
    {
        List<Medication> GetMedications();

        Medication GetMedication(Guid id);

        Medication AddMedication(Medication medication);

        void DeleteMedication(Medication medication);
    }
}
