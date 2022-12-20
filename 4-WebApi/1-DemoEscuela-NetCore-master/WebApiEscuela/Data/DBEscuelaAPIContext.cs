using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiEscuela.Models;

namespace WebApiEscuela.Data
{
    public class DBEscuelaAPIContext:DbContext
    {
        public DBEscuelaAPIContext(DbContextOptions<DBEscuelaAPIContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
    
    }
}
