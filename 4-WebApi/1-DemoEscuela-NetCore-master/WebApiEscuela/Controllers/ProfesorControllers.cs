using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEscuela.Data;
using WebApiEscuela.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiEscuela.Controllers
{
    //GET/api/profesor
    [Route("api/profesor")]
    [ApiController]
    public class ProfesorControllers : ControllerBase
    {
        //Inyeccion de Dependencias
        public DBEscuelaAPIContext Context { get; set; }
        public ProfesorControllers(DBEscuelaAPIContext context)
        {
            this.Context = context;
        }
        //Traer todos
        [HttpGet]
        public IEnumerable<Profesor> Get()
        {
            List<Profesor> profesores = Context.Profesores.ToList();
            return profesores;
        }
        //Traer uno
        [HttpGet("{id}")]
        public Profesor Get(int id)
        {
            Profesor profesor = Context.Profesores.Find(id);
            return profesor;
        }
        //Insertar
        [HttpPost]
        public ActionResult Post(Profesor profesor)
        {
            Context.Profesores.Add(profesor);
            Context.SaveChanges();
            return Ok();
        }
        //Modificar
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Profesor profesor)
        {
            if (id != profesor.ProfesorId)
            {
                return BadRequest();
            }
            Context.Entry(profesor).State = EntityState.Modified;
            Context.SaveChanges();
            return NoContent();
        }
        //Eliminar
        [HttpDelete("{id}")]
        public ActionResult<Profesor> Delete(int id)
        {
            var profesor = Context.Profesores.Find(id);

            if(profesor == null)
            {
                return NotFound();
            }
            Context.Profesores.Remove(profesor);
            Context.SaveChanges();
            return profesor;
        }
    }


}
