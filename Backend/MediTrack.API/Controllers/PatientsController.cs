using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediTrack.API.Data;
using MediTrack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MediTrack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/patients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        // POST: api/patients
        [HttpPost]
        public async Task<ActionResult<Patient>> CreatePatient(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPatients), new { id = patient.Id }, patient);
        }
    }
}
