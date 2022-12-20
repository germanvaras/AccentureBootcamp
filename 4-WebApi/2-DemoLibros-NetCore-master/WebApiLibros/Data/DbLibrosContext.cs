using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLibros.Entidades;

namespace WebApiLibros.Data
{
    public class DbLibrosContext:DbContext 
    {
        public DbLibrosContext(DbContextOptions<DbLibrosContext> options) : base(options) { }
        public DbSet<Autor> Autores { get; set; }


    }
}
