using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartMed_BackEnd_CodeChallenge.MedicationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed_BackEnd_CodeChallenge.Controllers
{
    [ApiController]
    public class MedicationsController : ControllerBase
    {
        private IMedicationData _medicationData;
        public MedicationsController(IMedicationData medicationData)
        {
            _medicationData = medicationData;
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetMedications()
        {
            return Ok(_medicationData.GetMedications());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetMedication(Guid id)
        {
            var medication = _medicationData.GetMedication(id);

            if(medication != null)
            {
                return Ok(_medicationData.GetMedications());
            }

            return NotFound("The medication you were loocking for was not found");
        }
    }
}
