using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEscuela.Data;
using WebApiEscuela.Models;
namespace WebApiEscuela.Controllers
{
    [Route("api/alumno")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        public DBEscuelaAPIContext Context { get; set; }
        public AlumnoController(DBEscuelaAPIContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public IEnumerable<Alumno> Get() {
            List<Alumno> alumnos = Context.Alumnos.ToList();
            Context.SaveChanges();
            return alumnos;
        }
        [HttpGet("{id}")]
        public Alumno Get(int id)
        {
            Alumno alumno = Context.Alumnos.Find(id);
            Context.SaveChanges();
            return alumno;
        }
        [HttpPost]
        public ActionResult Post(Alumno alumno)
        {
            Context.Alumnos.Add(alumno);
            Context.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Alumno alumno)
        {
            if(id != alumno.AlumnoId)
            {
                return BadRequest(); 
            }
            Context.Entry(alumno).State = EntityState.Modified;
            Context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Alumno alumno = Context.Alumnos.Find(id);
            if (alumno == null)
            {
                return BadRequest();
            }
            Context.Alumnos.Remove(alumno);
            Context.SaveChanges();
            return Ok();
        }


    }
}
