using Libreria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    public class DBPeliculasContext:DbContext
    {
        public DBPeliculasContext() : base("keyDBPeliculas") { }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Clasificacion> Clasificaciones { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
