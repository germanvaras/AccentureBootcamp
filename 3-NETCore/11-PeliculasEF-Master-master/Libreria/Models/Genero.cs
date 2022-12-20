using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{ 
    public class Genero
    {
        public int GeneroId { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(25)]
        public string Nombre { get; set; }

        List<Pelicula> peliculas { get; set; }
    }
}
