using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMedicos.Data;

namespace WebApiMedicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly DBHospitalContext _context;
        public HospitalController(DBHospitalContext context)
        {
            _context = context;
        }
        [HttpGet]
        public dynamic Get()
        {
            dynamic hospitales = (from h in _context.Hospitales
                                  select new { h.Nombre, h.Telefono, h.NumeroCamas }).ToList();
            if (hospitales == null)
            {
                return NotFound();
            }
            return hospitales;
        }
        [HttpGet("{NumCama}")]
        public dynamic Get(int NumCama)
        {
            var hospitales = (from h in _context.Hospitales
                              where h.NumeroCamas > NumCama
                              select new { h.Nombre, h.Telefono, h.NumeroCamas }).ToList();
            if (hospitales == null)
            {
                return NotFound();
            }

            return hospitales;
        }
    }
}
