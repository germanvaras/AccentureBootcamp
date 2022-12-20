using Libreria.Data;
using Libreria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Dac
{
    public static class DacPeliculas
    {
        public static DBPeliculasContext dBPeliculasContext =new DBPeliculasContext();

        public static List<Pelicula> Listar()
        {
            return dBPeliculasContext.Peliculas.ToList();
        }

        //Listar x Genero
        public static List<Pelicula> ListarXGenero(int idGenero)
        {
            List<Pelicula> peliculas = dBPeliculasContext.Peliculas.ToList();
            List<Pelicula> filteredList = new List<Pelicula>();

            foreach(Pelicula pela in peliculas)
            {
                if (pela.GeneroId==idGenero)
                {
                    filteredList.Add(pela);
                }
            }

            return filteredList;
        }

        //Nuevo
        public static int Nuevo(Pelicula nueva)
        {
            Pelicula pelicula = dBPeliculasContext.Peliculas.Add(nueva);

            return dBPeliculasContext.SaveChanges();
        }

        //Eliminar x Id
        public static int EliminarXId(int id)
        {
            var toDelete = dBPeliculasContext.Peliculas.Find(id);

            if(toDelete != null)
            {
                dBPeliculasContext.Peliculas.Remove(toDelete);
                return dBPeliculasContext.SaveChanges();
            }

            return 0;
        }

    }
}
