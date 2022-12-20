using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLibros.Data;
using WebApiLibros.Entidades;

namespace WebApiLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        public DbLibrosContext Context { get; set; }
        public AutorController(DbLibrosContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            List<Autor> autores = Context.Autores.ToList();
            return autores;
        }
        [HttpGet("{id}", Name = "ObtenerAutor")]
        public Autor Get( int id)
        {
            Autor autor = Context.Autores.Find(id);
            return autor;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            Context.Autores.Add(autor);
            Context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerAutor", new
            {
                id = autor.AutorId
            }, autor);

        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor autor)
        {
            if(id != autor.AutorId)
            {
                return BadRequest(); 
            }
            Context.Entry(autor).State = EntityState.Modified;
            Context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id)
        {
            Autor autor = Context.Autores.Find(id);
            if(autor == null)
            {
                return NotFound();
            }
            Context.Autores.Remove(autor);
            Context.SaveChanges();
            return autor;
        }


    }
}
