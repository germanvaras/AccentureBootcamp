using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacAuthor
    {
        static PubContext contextAuthor = new PubContext();
        public static List<Author> Listar()
        {

            List<Author> lista = contextAuthor.Authors.ToList();
            return lista;
        }
        public static Author TraerUno(string id)
        {

            Author author = contextAuthor.Authors.Find(id);
            return author;

        }
        public static int AgregarAutor(Author authorNuevo)
        {
            contextAuthor.Authors.Add(authorNuevo);
            int filasAfectadas = contextAuthor.SaveChanges();
            return filasAfectadas;

        }
        public static int ModificarAutor(Author authorModificar)
        {
            Author authorDb = contextAuthor.Authors.Find(authorModificar.au_id);
            if (authorDb != null)
            {
                authorDb.au_lname = "Carlos";
                authorDb.au_fname = "Jhonson";
                authorDb.city = "Cordoba";
                authorDb.state = "CB";
            }
            int filasAfectadas = contextAuthor.SaveChanges();
            return filasAfectadas;
        }
        public static int EliminarAutor(Author authorEliminar)
        {
            Author authorDb = contextAuthor.Authors.Find(authorEliminar.au_id);
            if (authorDb != null)
            {
                contextAuthor.Authors.Remove(authorDb);
            }
            int filasAfectadas = contextAuthor.SaveChanges();
            return filasAfectadas;
        }
    }
}
