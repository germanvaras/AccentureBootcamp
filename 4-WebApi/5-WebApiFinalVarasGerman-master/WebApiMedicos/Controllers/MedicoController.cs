using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHospital.Models;
using WebApiMedicos.Data;

namespace WebApiMedicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly DBHospitalContext _context;
        public MedicoController(DBHospitalContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            List<Doctor> Doctores = (from d in _context.Doctores
                                     select d).ToList();
            return Doctores;
        }
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            Doctor Doctor = (from d in _context.Doctores
                             where d.DoctorId == id
                             select d).SingleOrDefault();
            return Doctor;
        }
        [HttpGet("especialidad/{Especialidad}")]
        public Doctor GetPorEspecialidad(string especialidad)
        {
            Doctor Doctor = (from d in _context.Doctores
                             where d.Especialidad == especialidad
                             select d).SingleOrDefault();
            return Doctor;
        }
        [HttpPost]
        public ActionResult Post(Doctor doctor)
        {
            _context.Doctores.Add(doctor);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Get(int id, [FromBody] Doctor doctor)
        {
            if (id != doctor.DoctorId)
            {
                return BadRequest();
            }
            _context.Entry(doctor).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult<Doctor> Delete(int id)
        {
            var doctor = _context.Doctores.Find(id);
            if (doctor == null)
            {
                return NotFound();
            }
            _context.Doctores.Remove(doctor);
            _context.SaveChanges();
            return doctor;

        }




    }
}
