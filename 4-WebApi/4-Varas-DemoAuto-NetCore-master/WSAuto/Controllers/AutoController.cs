using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSAuto.Data;
using WSAuto.Models;

namespace WSAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly DBAutoContext _context;
        public AutoController(DBAutoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            List<Auto> autos = (from a in _context.Autos
                                select a).ToList();
            return autos;
        }
        [HttpGet("id/{id}")]
        public Auto GetById(int id)
        {
            Auto auto = (from a in _context.Autos
                         where a.AutoId == id
                         select a).SingleOrDefault();
            return auto;
        }
        [HttpGet("color/{color}")]
        public IEnumerable<Auto> GetByColor(string color)
        {
            List<Auto> autos = (from a in _context.Autos
                                where a.Color == color
                                select a).ToList();
            return autos;
        }

        [HttpGet("modelo/{modelo}")]
        public IEnumerable<Auto> GetByModel(string modelo)
        {
            List<Auto> autos = (from a in _context.Autos
                                where a.Modelo == modelo
                                select a).ToList();
            return autos;
        }


        [HttpGet("{modelo}/{marca}")]
        public dynamic Get(string modelo, string marca)
        {
            dynamic autos = (from a in _context.Autos
                                where a.Modelo == modelo && a.Marca == marca
                                select new {a.AutoId, a.Modelo, a.Marca});
            return autos;
        }

        [HttpPost]
        public ActionResult Post(Auto auto)
        {
            _context.Autos.Add(auto);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put (int id, [FromBody] Auto auto)
        {
            if (id != auto.AutoId)
            {
                return BadRequest();
            }
            _context.Entry(auto).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Auto> Delete(int id)
        {
            Auto AutoAEliminar = _context.Autos.Find(id);
            if(AutoAEliminar == null)
            {
                return BadRequest();
            }
            _context.Autos.Remove(AutoAEliminar);
            _context.SaveChanges();
            return Ok();
        } 



    }
}
